<?cs
##################################################################
# Site CSS - Place custom CSS, including overriding styles here.
?>

body {
  font-weight: normal;
  font-size: 11pt;
  font-family: Arial, sans-serif;
  color: #000000;
  line-height:150%;
  background-color: #ffffff;
  margin: 5px;
}

th, td {
  font-weight: normal;
  font-size: 11pt;
  font-family: Arial, sans-serif;
}

#banner, #header, #mainnav.nav, #main, #ctxtnav, #footer {
  margin:0;
}
#banner, #header {
  background-color: #ffffff;
}
#main, #ctxtnav, #footer {
  background-color: #ffffff;
}
#ctxtnav li ul {
  border: none;
}
#ctxtnav.nav a {
  color: #0000cc;
  text-decoration: underline;
  /* font-size: 7pt; */
}
#mainnav.nav {
  border-top: 1px solid #3366cc;
  background-color: #e5ecf9;
}
#metanav a {
  color: #0000cc;
  background: none;
  text-decoration: underline;
}
#metanav a:hover {
  background: none;
}

#banner {
  padding: 0px 5px 10px;
  /* border-top: 1px solid #c4c4c4; */
  /* border-left: 1px solid #c4c4c4; */
  /* border-right: 1px solid #c4c4c4; */
}
#header {
  padding-top: 10px;
}
#main {
  /* border-left: 1px solid #c4c4c4; */
  /* border-right: 1px solid #c4c4c4; */
}
div.wikipage {
  padding: 0;
}
div.wiki, div.timeline, div.roadmap, div.browser, div.report, div.ticket, div.search, div.settings, div.changeset, div.log, div.query, div.milestone, div.error, div.attachment, div.about, div.about_config, div.about_plugins {
  padding: 5px 35px 5px;
  font-size: 10pt;
}
#footer {
/*
  border-left: 1px solid #c4c4c4;
  border-right: 1px solid #c4c4c4;
  border-bottom: 1px solid #c4c4c4;
*/
  border-top: none;
  height: 20px;
  padding-right: 10px;
  padding-bottom: 0;
  line-height: 150%;
}
#disclaimer {
  border-top: 1px solid #3366cc;
  border-bottom: 1px solid #3366cc;
  padding: 7px 0 7px;
  background-color: #e5ecf9;
}
#footerlinks {
  padding-top: 5px;
  font-size: 10pt;
}
#footerlinks a {
  text-decoration: underline;
}
#poweredby, #poweredby a, #poweredby a:visited, #poweredby a:hover {
  color: #bbb;
}


/********************************* HYPERLINKS ******************************/

/* general links */

:link, :visited {
 text-decoration: none;
 color: #0000cc;
 border: none;
}
:link:hover, :visited:hover {
 background: none;
 color: #0000cc;
}

a:link    { color:#0000cc; text-decoration:none; background: none; border: none; }
a:visited { color:#0000cc; text-decoration:none; background: none; border: none; }
a:hover   { color:#0000cc; text-decoration:underline; background: none; border: none; }

/* existing wikipage */
a.wiki:link    { color:#0000cc; font-weight: normal; text-decoration:underline; background: none; }
a.wiki:visited { color:#0000cc; font-weight: normal; text-decoration:underline; background: none; }
a.wiki:hover   { color:#0000cc; font-weight: normal; text-decoration:underline; background: none; }

/* not existing wikipage */
a.missing:link    { color:#cc0000; text-decoration:underline; font-weight: normal; background: none; }
a.missing:visited { color:#cc0000; text-decoration:underline; font-weight: normal; background: none; }
a.missing:hover   { color:#cc0000; text-decoration:underline; font-weight: normal; background: none; }

a.closed:link, a.closed:visited { text-decoration: line-through; }

#mainnav.nav a, #mainnav.nav :link, #mainnav.nav :visited {
  font-weight: bold;
  background: none;
}

@media screen {
 a.ext-link .icon {
  background: url(<?cs var:chrome.href ?>/site/images/link_icon.png) left center no-repeat;
  padding-left: 20px;
 }
 * html a.ext-link .icon { display: inline-block; }
}


/******************************* NAVIGATIONS ********************************/



/* table of contents */
div.wiki-toc {
 width: 330px !important;
 font-size: 9pt;
}
div.wiki-toc ol {
 list-style-type: decimal;
 padding-left: 10pt;
}

div.wiki-toc a, div.wiki-toc a:link, div.wiki-toc a:visited, div.wiki-toc a:hover {
  font-weight: normal;
}

/* Navigation */
.nav h2, .nav hr { display: none }
.nav ul { font-size: 10pt; list-style: none; margin: 0; text-align: right }
.nav li {
 border-right: 1px solid #d7d7d7;
 display: inline;
 padding: 0 .75em;
 white-space: nowrap;
}
.nav li.last { border-right: none; }


/* Main navigation bar */
#mainnav {
 background: none;
 border: none;
 font-weight: normal;
 font-size: 10pt;
 font-family: Arial, sans-serif;
 margin: .66em 0 .33em;
 padding: .5em 0;
}


/**************************** HEADLINES / HEADINGS ***************************/

/* general headline setup */
h1, h2, h3, h4, h5 {
  color: #333333;
  font-family: Arial, sans-serif;
  font-weight: normal;
}

/* special headlines */
.wikipage h1, h1 {margin-left: -20px; margin-top: 30px; font-size: 2.0em; padding-bottom: 8px; border-bottom:1px solid #eaeaea; color: #333333; font-weight: bold; }
.wikipage h2, h2 {margin-left: -15px; margin-top: 30px; font-size: 1.4em; border-bottom:1px solid #eaeaea; color: #333333; font-weight: bold; }
.wikipage h3, h3 {margin-left: -10px; font-size: 1.3em; border-bottom: none; font-weight: bold; color: #333333; }
.wikipage h4, h4 {margin-left: -5px; font-size: 1.1em; border-bottom: none; font-weight:bold; color: #333333; }
.wikipage h5, h5 {margin-left: 0px; font-size: 1.0em; border-bottom: none; font-weight:bold; color: #333333; }

.description h1 {margin-left: 0px; margin-top: 30px; font-size: 2.0em; padding-bottom: 8px; border-bottom:1px solid #eaeaea; color: #333333; font-weight: bold; }
.description h2 {margin-left: 5px; margin-top: 30px; font-size: 1.4em; border-bottom:1px solid #eaeaea; color: #333333; font-weight: bold; }
.description h3 {margin-left: 5px; font-size: 1.2em; border-bottom: none; font-weight: bold; color: #333333; }
.description h4 {margin-left: 5px; font-size: 1.1em; border-bottom: none; font-weight:bold; color: #333333; }
.description h5 {margin-left: 5px; font-size: 1.0em; border-bottom: none; font-weight:bold; color: #333333; }



.browser h1, .log h1 { font-size: 1.4em; }


/****************************** LISTS *********************************/

ul {
  padding-left: 30px;
  list-style-type: square;
  list-style-image: url(<?cs var:chrome.href ?>/site/images/bullet.gif);
}


/****************************** TIMELINE *********************************/

dt :link:hover, dt :visited:hover { background-color: #eed; color: #000; text-decoration: none; }
dt.wiki a {
 color: #333;
 font-weight: normal;
 font-style: normal;
}

/* name of the object that was changed (e.g., a wiki page) */
dt em {
 border-bottom: none;
 color: #3559ff;
 font-style: normal;
 font-weight: bold;
 text-decoration: none;
}

/* time */
dt .time { color: #999; font-size: 80%; }

/* commit messages or wiki edit comments */
dd {
 font-size: 80%;
 margin: 0 0 .75em 5.5em;
 padding: 0;
 color: #776;
}

#legend dd {
  font-size: 10pt;
}


/* this section fixes a CSS problem with the default CSS templates
   where the timeline view repeats background images ad infinitum */
dt.wiki, dt.wiki a { background-repeat: no-repeat; }
dt.changeset, dt.changeset a { background-repeat: no-repeat; }
dt.newticket, dt.newticket a { background-repeat: no-repeat; }
dt.editedticket, dt.editedticket a { background-repeat: no-repeat; }
dt.closedticket, dt.closedticket a { background-repeat: no-repeat; }
dt.wiki, dt.wiki a { background-repeat: no-repeat; }
dt.milestone, dt.milestone a { background-repeat: no-repeat; }

/************************ SPECIAL FORMATTING *************************/

table.code {
  font-size: 11pt;
}
table.code th, table.code tbody td {
  font-size: 10pt;
}

#info {
  font-size: 14pt;
}
#jumprev {
  font-size: 12pt;
}
#altlinks a {
  text-decoration: underline;
}
#altlinks li {
  font-size: 10pt;
}

#prefs {
  font-size: 9pt;
}

pre.wiki {
  font-family: monospace;
}

dd.time, dd.author, dd.message {
  font-size:10pt;
}

p.percent {
  font-size: 9pt;
}

div.info dt, div.info dd {
  font-size: 10pt;
}

/************************ HEADER LINKS **************************/
.globallinks {
  color: #000000;
  font-size: 10pt;
  font-weight: normal;
  text-align: center;
}
.globallinks a, .globallinks a:link, .globallinks a:hover, .globallinks a:visited, .globallinks a:active {
  color: #0000cc;
  background: none;
  text-decoration: underline;
  border-bottom: none;
  font-weight: normal;
}
.globallinks a:hover {
  text-decoration: underline;
}

#custom-footer {
  color: #444;
  font-size: 9pt;
  text-align: center;
}

#currenttime {
  float: left;
  padding-left: 10px;
  color: #666;
}

blockquote {
  border: 1px solid #3366cc;
  background-color: #e5ecf9;
  padding: 1px 10px 1px;
  font-style: italic;
}

/* Colors for change types */
#chglist .edit, #overview .mod, .diff #legend .mod { background: #fd0 }
#chglist .delete, #overview .rem, .diff #legend .rem { background: #e44 }
#chglist .add, #overview .add, .diff #legend .add { background: #2d2 }
#chglist .copy, #overview .cp, .diff #legend .cp { background: #00f }
#chglist .move, #overview .mv, .diff #legend .mv { background: #000 }
#chglist .unknown { background: #fff }

/* Styles for the actual diff tables (side-by-side and inline) */
.diff table td del { background-color: #e44; color: #000; }
.diff table td del { color: #600 }
.diff table td ins { background-color: #2d2; color: #000; }
.diff table td ins { color: #060 }
.diff table.inline tbody.mod td del { background: #e44; color: #000 }
.diff table.inline tbody.mod td ins { background: #2d2; color: #000 }
.diff table.sidebyside tbody.mod td del { background: #e44; color: #000 }
.diff table.sidebyside tbody.mod td ins { background: #2d2; color: #000 }

/* Styles for the inline diff */
/*
.diff table.inline tbody.mod td.l, .diff table.inline tbody.rem td.l {
 background: #fdf;
 border-color: #c0c;
 border-style: solid;
 border-width: 0 1px 0 1px;
}

.diff table.inline tbody.mod td.r, .diff table.inline tbody.add td.r {
 background: #dff;
 border-color: #0aa;
 border-style: solid;
 border-width: 0 1px 0 1px;
}
*/

