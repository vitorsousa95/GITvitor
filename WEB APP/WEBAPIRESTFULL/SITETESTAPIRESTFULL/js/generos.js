
    /* Ao carregar o documento o mesmo inicia o conteudo desde script*/
    jQuery(document).ready(function(){
		/* Indica que o evento submit do form irá realizar esta ação agora*/
		jQuery('#formgenero').submit(function(){
			/* Neste contesto 'this' representa o form deste ID  #myform */                
			var dados = $(this).serialize();

			 var settings = {
			  "crossDomain": true,
			  "url": "http://localhost:59271/Api/Generos/",
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
		
		jQuery('#bntSalvar').click(function(){
			 Editing();
			 
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Tipo').val("");
		});
		
		jQuery('#bntCancelar').click(function(){
			$('#bntSubmit').show();
			$('#bntSalvar').hide();
			$('#bntCancelar').hide();
			
			$('#Id').val("");
			$('#Tipo').val("");
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
			"url": "http://localhost:59271/Api/Generos/"+id,
			"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				}
			}
	
			$.ajax(settings).done(function (response) {
				$('#Id').val(response.Id);
				$('#Tipo').val(response.Tipo);
				$('#Descricao').val(response.Descricao);
			});
		
	}
	
	function Editing(){
		var dados = $('#formgenero').serialize();
		var id = $('#Id').val();

		 var settings = {
		  "crossDomain": true,
		  "url": "http://localhost:59271/Api/Generos/"+id,
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
			  "url": "http://localhost:59271/Api/Generos/"+id,
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
				"url": "http://localhost:59271/Api/Generos/",
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
							+ 		'<th>Tipo</th>'
							+ 		'<th>Descrição</th>'
							+ 		'<th>Opções</th>'
							+ 	'</tr>'
							+ '</tbody>');

		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id       + '</td>'
						+ '<td>' + value.Tipo    + '</td>'
						+ '<td>' + value.Descricao    + '</td>'
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
	
	
  
  