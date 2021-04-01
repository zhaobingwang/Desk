$(function () {
    var l = abp.localization.getResource('Desk');
    var createModal = new abp.ModalManager(abp.appPath + 'AssetRecords/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'AssetRecords/EditModal');

    console.log(abp.appPath);

    var dataTable = $('#AssetRecordsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(desk.assets.assetRecord.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible:
                                        abp.auth.isGranted('Desk.Asset.Record.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible:
                                        abp.auth.isGranted('Desk.Asset.Record.Delete'),
                                    confirmMessage: function (data) {
                                        return l(
                                            'AssetRecordDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                        desk.assets.assetRecord
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
                    title: l('Asset:Record:Id'),
                    data: "id"
                },
                {
                    title: l('Asset:Record:Name'),
                    data: "name"
                },
                {
                    title: l('Asset:Record:Price'),
                    data: "price"
                },
                {
                    title: l('Asset:Record:CreationTime'),
                    data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                }
            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewRecordButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
