function CalculateMarks() {
    var math = $('#Math').val();
    var english = $('#English').val();
    var science = $('#Science').val();
    var hindi = $('#Hindi').val();
    var socialScience = $("#SocialScience").val();
    debugger;
    var totalMarks = ((isNaN(parseInt(math))) ? 0 : parseInt(math)) + ((isNaN(parseInt(english))) ? 0 : parseInt(english)) + ((isNaN(parseInt(science))) ? 0 : parseInt(science)) + ((isNaN(parseInt(hindi))) ? 0 : parseInt(hindi)) + ((isNaN(parseInt(socialScience))) ? 0 : parseInt(socialScience));
    $('#spTotalMarks').html(totalMarks);
    $('#trTotal').show();
}