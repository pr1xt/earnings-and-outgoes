var result_bg = document.getElementById("result_bg");
result_bg.style.display = 'none';

function showmoney(){
    result_bg.style.display = 'inline';

}

function hidemoney(){
    
result_bg.style.display = 'none';
}

function prevent(event){
    event.stopPropagation();
}

$("#btn-search").click(function(){ 
    $(this).html("SEARCHING...").attr("disabled", "disabled");
    $.ajax({
      url: 'search.php', 
      type: 'POST', // Tentukan type nya POST atau GET
      data: {keyword: $("#keyword").val()}, // Set data yang akan dikirim
      dataType: "json",
      beforeSend: function(e) {
        if(e && e.overrideMimeType) {
          e.overrideMimeType("application/json;charset=UTF-8");
        }
      },
      success: function(response){ 
        $("#btn-search").html("SEARCH").removeAttr("disabled");
        $("#view").html(response.result);
      },
      error: function (xhr, ajaxOptions, thrownError) { 
        alert(xhr.responseText); 
      }
    });
})