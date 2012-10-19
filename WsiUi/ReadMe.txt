About
=====

WsiHero is a GUI application to validate web services compliance with the web services interoperability (WSI) profiles.

More information: http://webservices20.blogspot.com/	
Feedback: Yaron Naveh (yaronn01@gmail.com)


Installation
============

1. Ensure Microsoft .Net framework 2.0 or higher is installed (http://www.microsoft.com/downloads/en/details.aspx?FamilyID=0856eacb-4362-4b0d-8edd-aab15c5e04f5&displaylang=en).

2. Ensure Java 5 or higher is installed (http://www.java.com/en/download/index.jsp).

3. Extract WsiHero.zip to some folder, for example c:\program files\WsiHero.

4. Since it is not legal for me to distribute the WSI command line utility, please download it by yourself as follows:

Download these two zip files to your machine:

http://ws-i.org/profiles/BPTestToolsProcess-1.2-2.0-Final.zip
http://www.ws-i.org/profiles/RSP1.0-Delivery-Package.zip

Do not extract them, just put them as .zip in the WsiHero folder (c:\program files\WsiHero).

In case the direct link do not work for some reason here is how to get the above files from the WSI site (http://www.ws-i.org/): From the "deliverables" section  of the site download "BP 1.2 and 2.0 Test Tools package" and "Reliable Secure Profile Delivery Package".


Usage
=====

1. Run WsiHero.exe from its folder.

2. Paste a Wsdl of Soap location to the textbox and press "Add".
Notes: 
- Location can be a local disk path or a Url. 
- Important: If the file contains Soap it must have the .Xml suffix.

For example the following can be put in the text box:

c:\soap_envelopes\soap.xml
c:\wsdl\service.wsdl
http://www.service.com/MyService.svc?wsdl


3. Repeat step (1) any number of times.

4. Click the arrow near the validation button and click the validation type you want to perform:

- For Soap 1.1 services choose "Basic Profile 1.2".
- For Soap 1.2 services choose "Basic Profile 2.0".
- For secured / reliable services choose "Reliable Secure Profile 1.0".

After a few seconds (depending on the input size) the WSI report will appear.


More information & feedback
============================

http://webservices20.blogspot.com/	

Yaron Naveh (yaronn01@gmail.com)
