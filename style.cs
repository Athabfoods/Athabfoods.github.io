/* Dropdown Button */
.dropbtn {
  background-color: #04AA6D;
  color: white;
  padding: 16px;
  font-size: 16px;
  border: none;
}

/* The container <div> - needed to position the dropdown content */
.dropdown {
  position: relative;
  display: inline-block;
}

/* Dropdown Content (Hidden by Default) */
.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f9f5f1;
  min-width: 100%;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

/* Links inside the dropdown */
.dropdown-content a {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
}

/* Change color of dropdown links on hover */
.dropdown-content a:hover {background-color: #362e33;}

/* Show the dropdown menu on hover */
.dropdown:hover .dropdown-content {display: block;}

/* Change the background color of the dropdown button when the dropdown content is shown */
.dropdown:hover .dropbtn {background-color: #3e8e41;}


<scrpit>
/* When the user clicks on the button, toggle between hiding and showing the dropdown content */

function myFunction() 
{

document.getElementById("myDropdown").classList.toggle("show");
}

//Close the dropdown if the iser clicks outside of it 
{
:
window.onclick = function(event)
{
  if
 (!event.target.matches('.dropbtn'))  {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; <dropdowns.length; i++) 
    {
        var openDropdown = dropdowns[i];
        if (openDropdown.classList.contains('show'))
        {openDropdown.classList.remove('show');
        }
      }
    }
  }
</script>




/* When the user clicks on the button,
toggle between hiding and showing the dropdown content */
function myFunction() {
  document.getElementById("myDropdown").classList.toggle("show");
}

// Close the dropdown menu if the user clicks outside of it
window.onclick = function(event) {
  if (!event.target.matches('.dropbtn')) {
    var dropdowns = document.getElementsByClassName("dropdown-content");
    var i;
    for (i = 0; i < dropdowns.length; i++) {
      var openDropdown = dropdowns[i];
      if (openDropdown.classList.contains('show')) {
        openDropdown.classList.remove('show');
      }
    }
  }
}



<style> 
.dropbtn  {
  background-color: #f9f5f1;
  color: white;
  padding: 16px;
  font-size: 16px;
  border: none;
  cursor: pointer;
}

.dropbtn:hover, .dropbtn:focus {
  background-color: #f9f5f1;
}

.dropdown {
  position: relative;
  display: inline-block;
}

.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f1f1f1;
  min-width: 160px;
  overflow: auto;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,2);
  z-index: 1; 
}

.dropdown-content a{
 color: black;
 padding: 12px 16px;
 text-decoration: none;
 display: block;
}

.dropdown a:hover {background-color: #ddd;}

.show {display: block;}
</style>
