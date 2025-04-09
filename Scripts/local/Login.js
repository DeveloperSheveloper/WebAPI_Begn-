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