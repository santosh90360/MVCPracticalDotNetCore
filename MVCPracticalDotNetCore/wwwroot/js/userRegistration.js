﻿function AddUser() {

    var firstName = $('#FirstName').val();
    var lastName = $('#LastName').val();
    var email = $('#Email').val();
    var password = $('#Password').val();   
    var gender = $("input[name='Gender']:checked").val();
    
    $('#txtFirstNameView').val(firstName);
    $('#txtLastNameView').val(lastName);
    $('#txtEmailView').val(email);
    $('#txtPasswordView').val(password);
    $('#spGenderView').html(gender);
    $("#addUserModal").modal('show');
}