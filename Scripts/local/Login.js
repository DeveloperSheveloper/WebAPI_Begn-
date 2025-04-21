$("#btnSignIn").on("click", function () {
    var username = $('#loginEmail').val();
    var password = $('#loginPassword').val();


    if (username === '') {
        $('#loginEmail').css('border-color', '#AF3F3F');
        $('#lblUsernameError').css('color', '#AF3F3F');
        $('#lblUsernameError').html("&nbsp;Username can not be empty");
    }
    else {
        $('#loginEmail').css('border-color', '');
        $('#lblUsernameError').html("");
    }

    if (password === '') {
        $('#loginPassword').css('border-color', '#AF3F3F');
        $('#lblPasswordError').css('color', '#AF3F3F');
        $('#lblPasswordError').html("&nbsp;Password can not be empty");
    }
    else {
        $('#loginPassword').css('border-color', '');
        $('#lblPasswordError').html("");
    }

});


$("#lnkRegister").on("click", function () {
         
    $(".registration-container").removeClass("hidden");
    $(".login-container").addClass("hidden");
});

$("#lnkLogin").on("click", function () {
    $(".login-container").removeClass("hidden");
    $(".registration-container").addClass("hidden");
});



$("#btnSignUp").on("click", function () {
    var regUsername = $('#regUsername').val();
    var regMobileNo = $('#regMobileNo').val();
    var regEmailID = $('#regEmailID').val();
    var regPassword = $('#regPassword').val();
    var regCPassword = $('#regCPassword').val();

    //Validations
    var validation = true;
    // : username
    if (regUsername === '') {
        $('#regUsername').css('border-color', '#AF3F3F');
        $('#lblRegUsernameError').css('color', '#AF3F3F');
        $('#lblRegUsernameError').html("&nbsp;Username can not be empty");
        validation = false;
    }
    else {
        $('#regUsername').css('border-color', '');
        $('#lblRegUsernameError').html("");
    }
    // : contactno
    if (regMobileNo === '') {
        $('#regMobileNo').css('border-color', '#AF3F3F');
        $('#lblRegContactError').css('color', '#AF3F3F');
        $('#lblRegContactError').html("&nbsp;Contact No can not be empty");
        validation = false;
    }
    else if (regMobileNo.length!== 10 || isNaN(regMobileNo)) {
        $('#regMobileNo').css('border-color', '#AF3F3F');
        $('#lblRegContactError').css('color', '#AF3F3F');
        $('#lblRegContactError').html("&nbsp;Enter a vaild contact number");
        validation = false;
    }
    else {
        $('#regMobileNo').css('border-color', '');
        $('#lblRegContactError').html("");
    }
    // : emailID
    if (regEmailID === '') {
        $('#regEmailID').css('border-color', '#AF3F3F');
        $('#lblRegEmailError').css('color', '#AF3F3F');
        $('#lblRegEmailError').html("&nbsp;Username can not be empty");
        validation = false;
    }
    else {
        $('#regEmailID').css('border-color', '');
        $('#lblRegEmailError').html("");
    }
    // : password
    if (regPassword === '') {
        $('#regPassword').css('border-color', '#AF3F3F');
        $('#lblRegPasswordError').css('color', '#AF3F3F');
        $('#lblRegPasswordError').html("&nbsp;Password can not be empty");
        validation = false;
    }
    else {
        $('#regPassword').css('border-color', '');
        $('#lblRegPasswordError').html("");
    }
    // : confirm password
    if (regCPassword === '') {
        $('#regCPassword').css('border-color', '#AF3F3F');
        $('#lblRegCPasswordError').css('color', '#AF3F3F');
        $('#lblRegCPasswordError').html("&nbsp;Confirm your password");
        validation = false;
    }
    else if (regCPassword !== regPassword) {
        $('#regCPassword').css('border-color', '#AF3F3F');
        $('#lblRegCPasswordError').css('color', '#AF3F3F');
        $('#lblRegCPasswordError').html("&nbsp; Password does not match");
        validation = false;
    }
    else {
        $('#regCPassword').css('border-color', '');
        $('#lblRegCPasswordError').html("");
    }

    if (!validation) return;

    $.ajax({
        url: 'Home/UserRegistration',
        type: 'POST',
        data: JSON.stringify({ username: regUsername, MobileNo: regMobileNo, emailId: regEmailID, password: regPassword }),
        contentType: 'application/json',
        success: function (response) {
            var response = JSON.parse(response);
            try {
                if (response.success) {
                    console.log("Success");
                }
            }
            catch (e) {
                throw e;
            }
        },
        error: function (xhr, status, error) {
            console.log("Ajax Error : ",error);
        }
    });

});