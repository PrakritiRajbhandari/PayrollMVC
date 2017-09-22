if (!window.app) {
    window.app = {};
}
alert = '123'
app.Registration = (function ($) {
    "use strict";

    var frmCreateModal = $("#modal-Create");

    var onDocumentReady = function () {

        initUi();
        initEvent();
    },
        initUi = function () {
            //console.log('Called initUi function.');
        },
        initEvent = function () {

            //console.log('Called initEvent function.');

            $("#lnkRegistrationCreate").on("click", Create);
            $("#btnSave").on("click", saveEntity);
        },
        Create = function () {
            console.log("here");

            $.get('/Registration/Create').done(function (data) {
                frmCreateModal.find('div.modal-body').html(data);
                frmCreateModal.find('.modal-title').html('Registration');
                frmCreateModal.modal();
                //initValidation();
            });
        },
        saveEntity = function () {
            var $form = frmCreateModal.find('#modal-Create');
            var url = 'Registration/Create';
            var model = {
                'FirstName': $('#FirstName').val(),
                'MiddleName': $('#MiddleName').val(),
                'LastName': $('#LastName').val(),
                'Gender': $('#Gender').val(),
                'Maritalstatus': $('#Maritalstatus').val(),
                'DateOfBirth': $('#DateOfBirth').val(),
                'Mobile': $('#Mobile').val(),
                'Email': $('#Email').val(),
                'Address': $('#Address').val()
                

            }



            $.ajax({
                url: url, //this is the submit URL
                type: 'POST', //or POST
                data: model,
                success: function (response) {
                    if (response.success) {
                        // frmCreateModal.modal('hide');
                        alert(response.message);
                        window.location.href = '/Registration/Index';
                    } else {
                        alert(response.message);
                    }
                }
            });
        }
,

initValidation = function () {
    var form = frmCreateModal.find('div.modal-body').find('form');
    form.removeData('validator');
    form.removeData('unobtrusiveValidation');
    $.validator.unobtrusive.parse(form);
};


    return {
        onDocumentReady: onDocumentReady
    };
})(jQuery);

jQuery(app.Registration.onDocumentReady);