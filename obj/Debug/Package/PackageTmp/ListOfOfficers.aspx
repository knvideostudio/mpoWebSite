<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfOfficers.aspx.cs" Inherits="mpoWebSite.ListOfOfficers" %>

<%@ Register src="control/bottomControl.ascx" tagname="bottomControl" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252" />
<meta http-equiv="Content-Language" content="en-us" />
<title>TSClub 5849 - List Of Officers 2013.</title>
<link href="css/default.css" rel="stylesheet" type="text/css" />
</head>

<body>
 <form id="form1" runat="server">
<table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse" width="100%">
  <tbody>
  <tr>
    <td style="width: 156px; height: 134px; text-align: center; vertical-align: middle;"><img alt="Toastmasters International" src="mpo3/toastLogo.jpg" width="154" height="134" /></td>
    <td style="width: 90%; text-align: right; vertical-align: bottom;">
   <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">
		<tbody>
		<tr>
			<td style="width: 80%;">&nbsp;</td>
			<td style="width: 20%;"  class="lnk1">&nbsp;<a href="faq.aspx">FAQ</a> | <a href="ContactUs.aspx">
			Contact Us</a>&nbsp;&nbsp;</td>
		</tr>
		<tr>
			<td style="width: 80%; height: 18px;" class="line"><img alt="" class="clr" src="img3/clearpixel.gif" width="1" height="1" /></td>
			<td style="width: 20%; height: 18px;" class="line"><img alt="" class="clr" src="img3/clearpixel.gif" width="1" height="1" /></td>
		</tr>
		<tr>
			<td style="width: 80%; height: 32px;" class="bg1"><img alt="" class="clr" src="img3/clearpixel.gif" width="1" height="1" /></td>
			<td style="width: 20%; height: 32px;" class="bg1"><img alt="Club #5849" class="clr" src="mpo3/club.jpg" width="119" height="28" /></td>
		</tr>
		<tr>
			<td style="width: 80%; height: 5px;" class="bg2"><img alt="" class="clr" src="img3/clearpixel.gif" width="1" height="1" /></td>
			<td style="width: 20%; height: 5px;" class="bg2"><img alt="" class="clr" src="img3/clearpixel.gif" width="1" height="1" /></td>
		</tr>
		<tr>
			<td style="width: 80%; height: 35px;" class="bg3">
    &nbsp;<a href="Default.aspx">Home</a> | 
    <a href="BenefitsAndResp.aspx">Benefits and Responsibilities</a> | 
    <a href="ListOfOfficers.aspx">List of Officers</a> | 
    <a href="NewsLetter.aspx">Newsletter</a> | 
    <a href="Schedule.aspx">Schedule</a> | 
    <a href="WhyInvest.aspx">Why Invest in Toastmasters?</a> | 
    <a href="Photos.aspx">Photos</a> | 
    <a href="KnMobileApps.aspx">Mobile App</a> | 
    <a href="Video.aspx">Videos</a>
</td>
			<td style="width: 80%; height: 35px;"  class="bg3" ><img alt="" class="clr" src="img3/clearpixel.gif" width="1" height="1" /></td>
		</tr>

	</tbody>

	</table>
    
    </td>
  </tr>
  
  <tr>
    <td style="height: 6px;" colspan="2" class="bg4"><img alt="" class="clr" src="img3/clearpixel.gif" width="1" height="1" /></td>
  </tr>
    <tr>
    <td colspan="2" class="bg2">
    
    <table style="width: 100%">
		<tr>
			<td style="width: 156px;">&nbsp;</td>
			<td style="width: 80%;">
			
			<img alt="Welcome to TSClub 5849" src="mpo3/slogan1.jpg" width="586" height="116" /></td>
		</tr>
	</table>
    
    </td>
  </tr>

<tr>
    <td style="height: 6px;" colspan="2" class="bg4"><img alt="" class="clr" src="img3/clearpixel.gif" width="1" height="1" /></td>
  </tr>

  <tr>
    <td align="left" valign="top" colspan="2">
    <table border="0" cellpadding="10" style="border-collapse: collapse;"  width="100%">
      <tbody>
      <tr>
        <td style="width: 70%; text-align: left; vertical-align: top;">
        <span class="tl1">List of Officers - 2013</span><br />
      <br />
      <ul>
          <li>President – Vivian, CC, CL</li>
          <li>Vice President of Education - Bill Allen </li>
          <li>Vice President Membership </li>
	      <li>Vice President Public Relations - Chris Nickov</li>
          <li>Secretary</li>
          <li>Treasurer</li>
          <li>Sergeant at Arms </li>
         </ul>	
<br />
<br />
 
		<br /><br />
		
		</td>
        <td style="width: 30%; text-align: center; vertical-align: top;">
		
	      
			<br />
			
			
			</td>
      </tr>
    </tbody>
    </table>
    </td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td style="height: 15px;" class="bg5" colspan="2"><img alt="" class="clr" src="img3/clearpixel.gif" width="1" height="1" /></td>
  </tr>  
  <tr>
    <td style="height: 6px;" class="bg4" colspan="2"><img alt="" class="clr"src="img3/clearpixel.gif" width="1" height="1" /></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td style="height: 20px;" class="sml" >
    <uc1:bottomControl ID="bottomControl1" runat="server" />
    </td>
  </tr>
</tbody>
</table>
</form>
</body>
</html>
