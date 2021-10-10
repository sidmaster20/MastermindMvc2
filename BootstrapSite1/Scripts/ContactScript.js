$().ready(function () {
    // validate the comment form when it is submitted
$("#ContactForm").validate();

});




function SaveContact() {

   ////// var Validate = $("#ContactForm").valid();
    debugger;
    var contact = {};

    if ($("#ContactForm").valid()) {

        contact.FirstName = $("#txtFirstName").val();
        contact.LastName = $("#txtLastName").val();
        contact.CompanyName = $("#txtCompanyName").val();
        contact.Email = $("#txtEmail").val();
        contact.Phone = $("#txtPhone").val();
        contact.Message = $("#txtMessage").val();

        var Contact = JSON.stringify(contact);

        $.ajax({
            url: 'Contact/SaveContact',
            data: {'Contact':Contact },
            dataType: 'json',
            type: 'POST',
            success: function (data) {

                $('.form-control').val('');
                if (data == 1) {
                    $('<div></div>').dialog({
                        modal: true,
                        title: "Confirmation",
                        open: function () {
                            var markup = 'Thank you!';
                            $(this).html(markup);
                        },
                        buttons: {
                            Ok: function () {
                                $(this).dialog("close");
                            }
                        }
                    });
                }
            },
            error: function (xhr, ajaxOptions, thrownError) {
                //some errror, some show err msg to user and log the error  
                alert(xhr.responseText);

            }
        });
    }
}