
    /* Ao carregar o documento o mesmo inicia o conteudo desde script*/
    jQuery(document).ready(function(){
		/* Indica que o evento submit do form irá realizar esta ação agora*/
		jQuery('#formlivro').submit(function(){
			/* Neste contesto 'this' representa o form deste ID  #myform */                
			var dados = $(this).serialize();

			 var settings = {
			  "crossDomain": true,
			  "url": "http://localhost:59271/Api/Livros",
			  "method": "POST",
			  "headers": {
				"Content-Type": "application/x-www-form-urlencoded",
				"Accept": "*/*"
			  },
			  "data": dados
			}

			$.ajax(settings).done(function (response) {
			    GetMethod();
			});
			
			return false;
        });
        
		TraValoresGenerosSelect();
		TraValoresEditorasSelect();
		
		jQuery('#bntSalvar').click(function(){
			 Editing();
			 
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Titulo').val("");
			$('#Isbn').val("");
			$('#Genero').val("");
			$('#Ativo select').val("true");
		});
		
		jQuery('#bntCancelar').click(function(){
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Titulo').val("");
			$('#Isbn').val("");
			$('#Genero').val("");
			$('#Ativo select').val("true");
		});
		
		GetMethod();
	});
	
	function GetByID(id){
        $('#bntSubmit').hide();
		$('#bntSalvar').show();
		$('#bntCancelar').show();
		
        var settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Livros/"+id,
			"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				}
			}
	
			$.ajax(settings).done(function (response) {
				$('#Id').val(response.Id);
				$('#Titulo').val(response.Titulo);
				$('#Isbn').val(response.Isbn);
				$('#Genero').val(response.Genero);
				$('#Ativo select').val(response.Ativo);
			});
		
	}
	
	function Editing(){
		var dados = $('#formlivro').serialize();
		var id = $('#Id').val();

		 var settings = {
		  "crossDomain": true,
		  "url": "http://localhost:59271/Api/Livros/"+id,
		  "method": "PUT",
		  "headers": {
			"Content-Type": "application/x-www-form-urlencoded",
			"Accept": "*/*"
		  },
		  "data": dados
		}

		$.ajax(settings).done(function (response) {
		    GetMethod();
		});
	}
	
	function Deleting(id){
			 var settings = {
			  "crossDomain": true,
			  "url": "http://localhost:59271/Api/Livros/"+id,
			  "method": "DELETE",
			  "headers": {
				"Content-Type": "application/x-www-form-urlencoded",
				"Accept": "*/*"
			  }
			}

			$.ajax(settings).done(function (response) {
			    GetMethod();
			});
	}
    
    function GetMethod(){
			var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Livros",
				"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				  }
				}

				$.ajax(settings).done(function (response) {
				  RefrestGrid(response);
				});
			
			return false;
    }
   
    function RefrestGrid(contentValue){
	   $('#tDataGrid').empty();
	   $('#tDataGrid').html(  '<tbody>'
							+ 	'<tr>'
							+ 		'<th>ID</th>'
							+ 		'<th>Titulo</th>'
							+ 		'<th>Isbn</th>'
							+ 		'<th>Genero</th>'
							+ 		'<th>Ativo</th>'
							+ 		'<th>Opções</th>'
							+ 	'</tr>'
							+ '</tbody>');

		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id       + '</td>'
						+ '<td>' + value.Titulo    + '</td>'
						+ '<td>' + value.Isbn    + '</td>'
						+ '<td>' + value.Genero    + '</td>'
						+ '<td>' + value.Ativo    + '</td>'
						+ '<td>' 
						+ 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
						+ 		'<div    class=\'col-md-6\'>'
						+ 			'<button class=\'btn btn-block btn-danger col-md-3 ajax\' type=\'button\'  onclick=\'Deleting('+ value.Id +')\'>Remover</button>'
						+ 		'</div>'
						+ 		'<div     class=\'col-md-6\'>'
						+ 			'<button  class=\'btn btn-block btn-success col-md-3\'    type=\'button\'  onclick=\'GetByID('+ value.Id +')\'\>Editar</button>'
						+ 		'</div>'
						+ 	'</div>'
						+ '</td>'
					+ '</tr>';
        $('#tDataGrid').append(row);
		});
    }
    function TraValoresGenerosSelect() {
        var settings = {
            "async": true,
            "crossDomain": true,
            "url": "http://localhost:59271/Api/Generos/",
            "method": "GET",
                "headers": {
                    "Content-Type": "application/json",
                    "Accept": "*/*"
                }
            }
    
            var selectbox = $('#Genero');
            selectbox.find('option').remove();
        
            $.ajax(settings).done(function (response) {
                for (let i = 0; i < response.length; i++) {
                    $('<option>').val(response[i].Id).text(response[i].Tipo).appendTo(selectbox);				
                }			
            });
	}
	function TraValoresEditorasSelect() {
        var settings = {
			  "async": true,
			  "crossDomain": true,
			  "url": "http://localhost:59271/Api/Editoras/",
			  "method": "GET",
			  "headers": {
				"Content-Type": "application/json",
				"Accept": "*/*"
			  }
            }
    
            var selectbox = $('#Editora');
            selectbox.find('option').remove();
        
            $.ajax(settings).done(function (response) {
                for (let i = 0; i < response.length; i++) {
                    $('<option>').val(response[i].Id).text(response[i].Nome).appendTo(selectbox);				
                }			
            });
    }
    
    
	
	
  
  