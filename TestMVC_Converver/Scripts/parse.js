$(function () {
    $("#Lang").change(function () {
        console.log("Selection Change");
    });

})


function parse() {
    console.log("parsed...")
    $("#Parsed").html($("#Raw").html());
    Prism.highlightAll();
}
