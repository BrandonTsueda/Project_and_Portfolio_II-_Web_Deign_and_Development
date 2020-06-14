/**********************

Syntax Errors (5 total Syntax Errors)
‣ these errors (also known as parsing errors) occur when the programmer types
something incorrectly, such as:
‣ forgetting to close a string with quotes, or escaping quotes with \
‣ forgetting to separate array values with a comma
‣ missing other necessary syntax characters such as ( ) , { }

Runtime Errors (6 total Runtime Errors)
‣ runtime errors are exceptions that occur during the code’s execution
‣ because these are not syntax issues, they will not cause an error until the problematic
line of code is executed
‣ once the error occurs however, script execution will stop
‣ the most common cause of runtime errors is when a variable or function does not exist
(or the reference is misspelled), or when an object being accessed is invalid
‣ most often, if you think your logic is correct, then it is a spelling typo
14

Logic Errors (3 total Logic Errors)
‣ logic “errors” are the apparent lack of success (the desired effect doesn’t happen)
‣ this is the most difficult type of error to find - this type of problem does not return an
actual error because no syntax or runtime exception has occurred
‣ the problem is simply in the programmer’s logic

***********************/
// 14 total errors
// LABEL EACH CORRECTED ERROR WITH A COMMENT!!!

//THE LINE BELOW IS CORRECT. (It is the opening of a self executing function)
(function(){
	
	// Variable initialization (DO NOT FIX ANY OF THE BELOW VAR's)
	var resultsDIV = document.getElementById("results"),
		searchInput = document.forms[0].search,
		currentSearch = ''
	;
	
	// Validates search query
	//var validqte = function(query) - corrected spelling also added {} to function body
	var validate = function(query)
	{
		
		// Trim whitespace from start and end of search query
		while(query.charAt(0) = " "){ 
			query = query.substring(1, query.length);
		};
		while(query.charat(query.length-1) === ""){  
			query = query.substring(0, query.length-1);
		;
		
		// Check search length, must have 3 characters
		if(query.length < 3){
			//alert("Your search query is too small, try again.); 
			alert("Your search query is too small, try again."); 

			
			// (DO NOT FIX THE LINE DIRECTLY BELOW)
			searchInput.focus();
			return;
		};
		
		search(query);
	};
	
	// Finds search matches
	//var search = function(query) - added a { } to the function body and a } to the for loop body, the for body, and the if body
	var search = function(query)
	{
		
		// SPLIT the user's search query string into an array
		var queryArray = query.join(" "); 
		
		// array to store matched results from database.js
		var results = [];

		// loop through each index of db array
		for(var i=0, j=db.length; i<j; i++){
		
			// each db[i] is a single video item, each title ends with a pipe "|"
			// save a lowercase variable of the video title
			var dbTitleEnd = db[i].indexOf('|');
			var dbitem = db[i].tolowercase().substring(0, dbTitleEnd);
			
			// loop through the user's search query words
			// save a lowercase variable of the search keyword
			for(var ii=0, jj=queryArray.length; ii<jj; ii++){
				var qitem = queryArray[ii].tolowercase(); 
				
				// is the keyword anywhere in the video title?
				// If a match is found, push full db[i] into results array
				var compare = dbitem.indexOf(qitem);
				if(compare !== -1){
					results.push(db[i]);
				}
			}	
		}	
	}	
		
		results.sort();
		
		// Check that matches were found, and run output functions
		if(results.length = 0){ 
			noMatch();
		}else{
			showMatches(results);
		};
	};
	
	// Put "No Results" message into page (DO NOT FIX THE HTML VAR NOR THE innerHTML)
	var noMatch = function(){
		var html = ''+
			'<p>No Results found.</p>'+
			'<p style="font-size:10px;">Try searching for "JavaScript".  Just an idea.</p>'
		;
		resultsDIV.innerHTML = html;
	};
	
	// Put matches into page as paragraphs with anchors
	var showMatches = function(results){
		
		// THE NEXT 4 LINES ARE CORRECT.
		var html = '<p>Results</p>', 
			title, 
			url
		;
		
		// loop through all the results search() function
		for(var i=0, j=results.length; i<j; i++){
		
			// title of video ends with pipe
			// pull the title's string using index numbers
			titleEnd = results[i].indexOf('|');
			title = results[i].subString(0, titleEnd);
			
			// pull the video url after the title
			url = results[i].substring(results[i].indexOf('|')+1, results[i].length);
			
			// make the video link - THE NEXT LINE IS CORRECT.
			html += '<p><a href=' + url + '>' + title + '</a></p>';
		};
		resultsDIV.innerHTML = html; //THIS LINE IS CORRECT.
	};
	
	// THE LINE DIRECTLY BELOW IS CORRECT
	document.forms[0].onsubmit = function(){
		var query = searchInput.value;
		validqte(query);

 
        // THE LINE DIRECTLY BELOW IS CORRECT
		return false;
	;
	
//THE LINE BELOW IS CORRECT. It is the close of the self executing function.
})();