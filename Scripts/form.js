$(document).ready(function () {

    // form submit handler
    $('#leadform').click(function (e) {
        e.preventDefault();

        if ($('#leadform').valid()) {

            // disable button
            $('#submit').attr('disabled', 'disabled');

            // create post data to send
            var postdata = {};
            postdata.FirstName = $('#firstname').val();
            postdata.LastName = $('#lastname').val();
            postdata.Gender = $('#gender').val();
            postdata.State = $('#state').val();
            postdata.Birthdate = $('#birthdate').val();
            postdata.PrimaryPhone = $('#primaryphone').val();
            postdata.SecondaryPhone = $('#secondaryphone').val();

            // make ajax call to post data to API
            $.ajax({
                type: 'POST',
                url: '/api/form/submit',
                data: JSON.stringify(postdata),
                cache: false,
                processData: false,
                dataType: "json",
                contentType: 'application/json; charset=utf-8',
                success: function (response) {
                    if (response.success) {
                        // Move to thank you page
                        alert('thank you');
                    }
                },
                error: function (response) {
                    // failed, re-enable button
                    $('#submit').removeAttr('disabled');
                }
            });
        }
    });

});