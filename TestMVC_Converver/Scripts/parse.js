$(function () {
    
    // Working... But verbose and junky...
    $("#Lang").change(function () {
        console.log("Language dropdown selection changed");
        //console.log($("#Lang option:selected").val());
        var selected = $("#Lang option:selected").val();
        var langClass = PrismName[selected - 1].PrismName;
        $("#Parsed").attr('class', langClass);
        parse();
    });
})


function parse() {
    console.log("Runing *parse* function")
    $("#Parsed").html($("#Raw").html());
    Prism.highlightAll();
}
