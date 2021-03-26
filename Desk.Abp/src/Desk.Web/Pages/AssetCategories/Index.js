$(function () {
    var l = abp.localization.getResource('Desk');
    var createModal = new abp.ModalManager(abp.appPath + 'AssetCategories/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'AssetCategories/EditModal');

    console.log(abp.appPath);

    var dataTable = $('#AssetCategoriesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(desk.assets.assetCategory.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible:
                                        abp.auth.isGranted('Desk.Asset.Category.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible:
                                        abp.auth.isGranted('Desk.Asset.Category.Delete'),
                                    confirmMessage: function (data) {
                                        return l(
                                            'AssetCategoryDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                        desk.gist.aBPDemo.authors.author
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Id'),
                    data: "id"
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('ParentId'),
                    data: "parentId"
                },
                {
                    title: l('ParentName'),
                    data: "parentName"
                },
                //{
                //    title: l('BirthDate'),
                //    data: "birthDate",
                //    render: function (data) {
                //        return luxon
                //            .DateTime
                //            .fromISO(data, {
                //                locale: abp.localization.currentCulture.name
                //            }).toLocaleString();
                //    }
                //}
            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewCategoryButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
