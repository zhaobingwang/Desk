﻿using Desk.Gist.ABPDemo.Authors;
using Desk.Gist.ABPDemo.Books;
using Desk.Gist.ABPDemo.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Desk.Gist.ABPDemo.Books
{
    [Authorize(ABPDemoPermissions.Books.Default)]
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>, IBookAppService
    {
        private readonly IAuthorRepository _authorRepository;

        public BookAppService(IRepository<Book, Guid> repository, IAuthorRepository authorRepository) : base(repository)
        {
            GetPolicyName = ABPDemoPermissions.Books.Default;
            GetListPolicyName = ABPDemoPermissions.Books.Default;
            CreatePolicyName = ABPDemoPermissions.Books.Create;
            UpdatePolicyName = ABPDemoPermissions.Books.Edit;
            DeletePolicyName = ABPDemoPermissions.Books.Delete;
            _authorRepository = authorRepository;
        }

        public override async Task<BookDto> GetAsync(Guid id)
        {
            var queryable = await Repository.GetQueryableAsync();

            var query = from book in queryable
                        join author in _authorRepository on book.AuthorId equals author.Id
                        where book.Id == id
                        select new { book, author };

            var queryResult = await AsyncExecuter.FirstOrDefaultAsync(query);
            if (queryResult == null)
            {
                throw new EntityNotFoundException(typeof(Book), id);
            }

            var bookDto = ObjectMapper.Map<Book, BookDto>(queryResult.book);
            bookDto.AuthorName = queryResult.author.Name;
            return bookDto;
        }

        public override async Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Book.Name);
            }

            var queryable = await Repository.GetQueryableAsync();

            var query = from book in queryable
                        join author in _authorRepository on book.AuthorId equals author.Id
                        orderby input.Sorting
                        select new { book, author };

            query = query
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);

            var queryResult = await AsyncExecuter.ToListAsync(query);

            var bookDtos = queryResult.Select(x =>
            {
                var bookDto = ObjectMapper.Map<Book, BookDto>(x.book);
                bookDto.AuthorName = x.author.Name;
                return bookDto;
            }).ToList();

            var totalCount = await Repository.GetCountAsync();
            return new PagedResultDto<BookDto>(totalCount, bookDtos);
        }

        public async Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync()
        {
            var authors = await _authorRepository.GetListAsync();
            return new ListResultDto<AuthorLookupDto>(ObjectMapper.Map<List<Author>, List<AuthorLookupDto>>(authors));
        }
    }
}
