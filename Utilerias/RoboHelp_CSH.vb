' Copyright© 2009 Adobe Systems Incorporated. All rights reserved.
' RoboHelp_CSH.vb
' The Helper function for Context Sensitive Help(WebHelp Pro and FlashHelp Pro)
'
'     Syntax:
'     Public Function RH_ShowHelp(strServer As String, projectType As Integer, strProject As String, ParamType As Integer, strParamValue As String, strArea As String) As Boolean
'
'     strServer
'           URL to the RoboHelp Server ("http://www.myurl.com/robohelp/rest")
'
'      projectType
'           specifying the type of project
'                WEB_HELP_PRO
'                FLASH_HELP_PRO

'      strProject
'           name of the Project to be looked into for context sensitive help
'
'     ParamType
'          Command to display help. One of the following:
'                    CSH_DISPLAY_CONTEXT     ' Displays the topic associated with the Map ID sent in strParamValue
'                                          if 0, then default topic is displayed.
'               The following display the default topic and the Search, Index, or TOC pane.
'               Note: The pane displayed in WebHelp Enterprise will always be the window's default pane.
'                   CSH_DISPLAY_SEARCH
'                   CSH_DISPLAY_INDEX
'                   CSH_DISPLAY_TOC
'               
'                   CSH_DISPLAY_WINDOW      ' Displays the topic with the window name having the value sent in strParamValue
'
'     strParamValue
'           Map ID associated with the topic to open (if using CSH_DISPLAY_CONTEXT), 
'           Window Name associated with the topic to open (if using CSH_DISPLAY_WINDOW),
'           otherwise 0
'
'     strArea
'            Area name of the RoboHelp Serer where the project is published.

'     Examples:
'          ' First, create a RoboHelp_CSH object 
'          Public cHelp as new RoboHelp_CSH
'
'          cHelp.RH_ShowHelp ("http://www.myurl.com/robohelp/rest",  PROJ_WEB_HELP, cHelp.CSH_DISPLAY_CONTEXT, "10" , "genral")  'Show map id 10 on remote WebHelp
'
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'    To use airplane help, we need to specify offline help source on help calls.
'    Help calls will use the primary help when an internet connection is present, otherwise they will fall back on the local help source provided.
'
'    Public Function RH_ShowLocalHelp(hParent As Object, strHelpURL As String, nCommand As Integer, nData As Integer) As Boolean
'
'   hParent
'          Handle to the parent window. This is currently reserved for future versions of the API.
'          Can be a window handle or 0.
'
'     strHelpURL
'          WebHelp :
'               Path to help start page ("http://www.myurl.com/help/help.htm" or "/help/help.htm")
'
'          HTML Help :
'               Path to HTML help file ("/help/help.chm")
'               
'          Win Help: 
'               Path to Win help file ("/help/help.hlp")
'
'     uCommand
'          Command to display help. One of the following:
'                    SH_DISPLAY_CONTEXT     ' Displays the topic associated with the Map ID sent in strParamValue
'                                          if 0, then default topic is displayed.
'               The following display the default topic and the Search, Index, or TOC pane.
'               Note: The pane displayed in WebHelp Enterprise will always be the window's default pane.
'                    CSH_DISPLAY_SEARCH
'                    CSH_DISPLAY_INDEX
'                    CSH_DISPLAY_TOC
'
'     nData
'         Map ID associated with the topic to open (if using CSH_DISPLAY_CONTEXT),
'         otherwise 0
'
'   returns true when the help is shown successfully, else false is returned.
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports SHDocVw
Imports System
Imports System.IO
Imports Microsoft.Win32
Imports System.Web
Imports System.Windows.Forms

Namespace RoboHelpAPI
    Public Class RoboHelp_CSH
        Public Const CSH_DISPLAY_CONTEXT As Integer = 1
        Public Const CSH_DISPLAY_TOC As Integer = 2
        Public Const CSH_DISPLAY_INDEX As Integer = 3
        Public Const CSH_DISPLAY_SEARCH As Integer = 4
        Public Const CSH_DISPLAY_WINDOW As Integer = 5

        Public Const PROJ_WEB_HELP As Integer = 1
        Public Const PROJ_FLASH_HELP As Integer = 2

        Public m_strWindowName, m_strURL As String
        Public m_bUseProp As Boolean
        Public m_bToolbar, m_bLocation, m_bDirectories, m_bStatus, m_bScrollbars As Boolean
        Public m_bMenubar, m_bResizable As Boolean
        Public m_nLeft, m_nTop, m_nWidth, m_nHeight As Integer
        Public m_bLeftPercent, m_bTopPercent, m_bWidthPercent, m_bHeightPercent As Boolean
        Private HttpReq As New MSXML2.XMLHTTP60
        Public Shared m_cBrowser As IWebBrowserApp
        Public Shared m_cExplorer As InternetExplorer
        Public Shared c_szHtmlScript As String = "<html><head><script>function fnGetHorzSize(nSize, nPercent){	return parseInt((nPercent==1)?screen.availWidth*nSize/100:nSize);	};function fnGetVertSize(nSize, nPercent){	return parseInt((nPercent==1)?screen.availHeight*nSize/100:nSize);	};{var nLeft=<%nLeft%>;var nTop=<%nTop%>;var nWidth=<%nWidth%>;var nHeight=<%nHeight%>;var bLeftPercent=<%bLeftPercent%>;var bTopPercent=<%bTopPercent%>;var bWidthPercent=<%bWidthPercent%>;var bHeightPercent=<%bHeightPercent%>;var bUseProp=<%bUseProp%>;var bToolbar=<%bToolbar%>;var bLocation=<%bLocation%>;var bDirectories=<%bDirectories%>;var bStatus=<%bStatus%>;var bScrollbars=<%bScrollbars%>;var bMenubar=<%bMenubar%>;var bResizable=<%bResizable%>;var strWindowName='<%strWindowName%>';var strURL='<%strURL%>';var strProps='';if(bUseProp==1){strProps+='left='+fnGetHorzSize(nLeft, bLeftPercent);strProps+=',top='+fnGetVertSize(nTop, bTopPercent);strProps+=',width='+fnGetHorzSize(nWidth, bWidthPercent);strProps+=',height='+fnGetVertSize(nHeight, bHeightPercent);if(bToolbar==1)	strProps+=',toolbar=1';if(bLocation)strProps+=',location=1';if(bDirectories) strProps+=',directories=1'; if(bStatus)		strProps+=',status=1';if(bMenubar)		strProps+=',menubar=1';if(bScrollbars)	strProps+=',scrollbars=1';if(bResizable)	strProps+=',resizable=1';window.open(strURL, strWindowName, strProps);};else window.location = strURL;};</script></head><body></body></html>"
        Public Shared m_bUseServer As Boolean = True

        Public Function RH_ShowHelpPro(ByVal m_strServer As String, ByVal projectType As Integer, ByVal strProject As String, ByVal ParamType As Integer, ByVal strParamValue As String, ByVal strArea As String) As Boolean
            Dim url As String
            url = m_strServer
            m_strURL = "http://"
            Dim nPos1, nPos2 As Integer
            nPos1 = url.IndexOf("//", 0)
            nPos2 = url.IndexOf(("/"), nPos1 + 2)
            If nPos2 >= nPos1 + 2 And nPos1 >= 0 Then
                m_strURL += url.Substring(nPos1 + 2, nPos2 - nPos1 - 2)
            End If

            Dim strContext As String
            If (ParamType = CSH_DISPLAY_WINDOW) Then
                strContext = "prj&wnd=" + strParamValue
            Else
                strContext = "ctx&context=" + strParamValue
            End If

            url = "{0}/robowindow?wtype={1}&project={2}&area={3}"
            url = String.Format(url, m_strServer, strContext, strProject, strArea)

            If projectType = PROJ_FLASH_HELP Then
                url += "&type=flashhelp"
            End If

            HttpReq.open("GET", url, False)
            HttpReq.send()
            If HttpReq.status <> 200 Then
                MsgBox("Unable to Connect to Server")
                Return False
            End If

            ' the xml data recieved
            MsgBox(HttpReq.responseText)

            ParseXml()

            Dim strPage As String = c_szHtmlScript
            Dim strFile As String
            strFile = CreatePage(strPage)
            m_cExplorer = New InternetExplorer
            m_cExplorer = CreateObject("InternetExplorer.Application")
            m_cBrowser = m_cExplorer
            If IsNothing(m_cBrowser) = 0 Then
                m_cBrowser.Navigate(strFile, vbNull, vbNull, vbNull, vbNull)
                m_cBrowser.Visible = True
                Return True
            End If

            Return False
        End Function

        ' Private function to parse the xml response 
        Private Sub ParseXml()
            Dim objDoc As New MSXML2.DOMDocument60
            Dim windowNodeList, styleNodeList, locationNodeList As MSXML2.IXMLDOMNodeList
            Dim objNode, styleNode, locationNode, attrNode As MSXML2.IXMLDOMNode
            Dim windowNodeMap, styleNodeMap, locationNodeMap As MSXML2.IXMLDOMNamedNodeMap
            Dim tempURL As String

            If objDoc.loadXML(HttpReq.responseText) Then
                windowNodeList = objDoc.getElementsByTagName("Window")
                styleNodeList = objDoc.getElementsByTagName("Style")
                locationNodeList = objDoc.getElementsByTagName("Location")

                objNode = windowNodeList.nextNode
                windowNodeMap = objNode.attributes

                attrNode = windowNodeMap.getNamedItem("URL")
                If (Not (attrNode Is Nothing)) Then
                    tempURL = attrNode.text
                    If (tempURL.IndexOf("http://") < 0) Then
                        m_strURL += tempURL
                    Else
                        m_strURL = tempURL
                    End If
                End If
                attrNode = windowNodeMap.getNamedItem("Name")
                If (Not (attrNode Is Nothing)) Then
                    m_strWindowName = attrNode.text
                    Dim nPos As Integer = m_strWindowName.IndexOf("|")
                    If (nPos > 0) Then
                        m_strWindowName = m_strWindowName.Substring(nPos + 1)
                    End If
                End If

                attrNode = windowNodeMap.getNamedItem("UseProp")
                Try
                    m_bUseProp = attrNode.text
                Catch
                    m_bUseProp = False
                End Try


                ' parsing the style information
                styleNode = styleNodeList.nextNode
                styleNodeMap = styleNode.attributes

                attrNode = styleNodeMap.getNamedItem("Toolbar")
                m_bToolbar = attrNode.text

                attrNode = styleNodeMap.getNamedItem("Directories")
                If (Not (attrNode Is Nothing)) Then
                    m_bDirectories = attrNode.text
                End If

                attrNode = styleNodeMap.getNamedItem("Status")
                If (Not (attrNode Is Nothing)) Then
                    m_bStatus = attrNode.text
                End If

                attrNode = styleNodeMap.getNamedItem("Scrollbars")
                If (Not (attrNode Is Nothing)) Then
                    m_bScrollbars = attrNode.text
                End If


                attrNode = styleNodeMap.getNamedItem("Menubar")
                If (Not (attrNode Is Nothing)) Then
                    m_bMenubar = attrNode.text
                End If

                attrNode = styleNodeMap.getNamedItem("Resizable")
                If (Not (attrNode Is Nothing)) Then
                    m_bMenubar = attrNode.text
                End If

                locationNode = locationNodeList.nextNode
                locationNodeMap = locationNode.attributes


                attrNode = locationNodeMap.getNamedItem("Left")
                If (Not (attrNode Is Nothing)) Then
                    m_nLeft = attrNode.text
                End If

                attrNode = locationNodeMap.getNamedItem("Top")
                If (Not (attrNode Is Nothing)) Then
                    m_nTop = attrNode.text
                End If

                attrNode = locationNodeMap.getNamedItem("Width")
                If (Not (attrNode Is Nothing)) Then
                    m_nWidth = attrNode.text
                End If

                attrNode = locationNodeMap.getNamedItem("Height")
                If (Not (attrNode Is Nothing)) Then
                    m_nHeight = attrNode.text
                End If

                attrNode = locationNodeMap.getNamedItem("LeftType")
                If (Not (attrNode Is Nothing)) Then
                    m_bLeftPercent = attrNode.text
                End If

                attrNode = locationNodeMap.getNamedItem("TopType")
                If (Not (attrNode Is Nothing)) Then
                    m_bTopPercent = attrNode.text
                End If

                attrNode = locationNodeMap.getNamedItem("WidthType")
                If (Not (attrNode Is Nothing)) Then
                    m_bWidthPercent = attrNode.text
                End If

                attrNode = locationNodeMap.getNamedItem("HeightType")
                If (Not (attrNode Is Nothing)) Then
                    m_bHeightPercent = attrNode.text
                End If

            End If
        End Sub

        ' Function to create a temporary page to show the Context Sensitive Help
        Private Function CreatePage(ByRef strPage As String) As String
            Dim strFile As String
            BindParam(strPage, "nLeft", m_nLeft.ToString)
            BindParam(strPage, "nTop", m_nTop.ToString)
            BindParam(strPage, "nWidth", m_nWidth.ToString)
            BindParam(strPage, "nHeight", m_nHeight.ToString)
            BindParam(strPage, "bLeftPercent", m_bLeftPercent)
            BindParam(strPage, "bTopPercent", m_bTopPercent)
            BindParam(strPage, "bWidthPercent", m_bWidthPercent)
            BindParam(strPage, "bHeightPercent", m_bHeightPercent)

            BindParam(strPage, "bUseProp", m_bUseProp)
            BindParam(strPage, "bToolbar", m_bToolbar)
            BindParam(strPage, "bLocation", m_bLocation)
            BindParam(strPage, "bDirectories", m_bDirectories)
            BindParam(strPage, "bStatus", m_bStatus)
            BindParam(strPage, "bMenubar", m_bMenubar)
            BindParam(strPage, "bScrollbars", m_bScrollbars)
            BindParam(strPage, "bResizable", m_bResizable)
            BindParam(strPage, "strWindowName", m_strWindowName)
            BindParam(strPage, "strURL", m_strURL)

            strFile = Application.CommonAppDataPath + "\help.htm"
            Dim cStream As StreamWriter = New StreamWriter(strFile)
            cStream.Write(strPage)
            cStream.Close()

            Return strFile
        End Function

        ' Function to show the local help
        Public Function RH_ShowLocalHelp(ByVal hParent As Object, ByVal strHelpURL As String, ByVal nCommand As Integer, ByVal nData As Integer) As Boolean
            '// process different kinds of help
            If IsWinHelp(strHelpURL) = True Then
                If RH_ShowWinHelp(hParent, strHelpURL, nCommand, nData) = True Then
                    Return True
                End If
            End If
            If IsHtmlHelp(strHelpURL) = True Then
                If RH_ShowHtmlHelp(hParent, strHelpURL, nCommand, nData) = True Then
                    Return True
                End If
            End If
            If IsWebHelp(strHelpURL) = True Then
                If RH_ShowWebHelp(hParent, strHelpURL, nCommand, nData) = True Then
                    Return True
                End If
            End If

            Return False
        End Function

        Private Function GetURLExt(ByVal strURL As String) As String
            Dim strRet As String = ""
            Dim nPos1 As Integer
            Dim nPos2 = strURL.LastIndexOf("?")
            If nPos2 < 0 Then nPos2 = strURL.Length

            nPos1 = strURL.LastIndexOf(".", nPos2)
            If nPos1 >= 0 Then
                nPos2 = strURL.IndexOfAny("?>#".ToCharArray(), nPos1)
                If nPos2 < 0 Then nPos2 = strURL.Length
                strRet = strURL.Substring(nPos1, nPos2 - nPos1)
            End If
            Return strRet
        End Function

        Private Function IsWinHelp(ByVal strHelpURL As String) As Boolean
            Dim strExt As String = GetURLExt(strHelpURL)

            Return String.Compare(strExt, ".hlp", True) = 0
        End Function

        Private Function IsHtmlHelp(ByVal strHelpURL As String) As Boolean
            Dim strExt As String = GetURLExt(strHelpURL)

            Return String.Compare(strExt, ".chm", True) = 0
        End Function

        Private Function IsWebHelp(ByVal strHelpURL As String) As Boolean
            Dim strExt As String = GetURLExt(strHelpURL)

            Return String.Compare(strExt, ".htm", True) = 0
        End Function
        


        Private Function RH_ShowWinHelp(ByVal hParent As Object, ByVal strHelpURL As String, ByVal nCommand As Integer, ByVal nData As Integer) As Boolean
            If nCommand = CSH_DISPLAY_CONTEXT Then
                Help.ShowHelp(hParent, strHelpURL, HelpNavigator.TopicId)
            ElseIf nCommand = CSH_DISPLAY_TOC Then
                Help.ShowHelp(hParent, strHelpURL, HelpNavigator.TableOfContents)

            ElseIf nCommand = CSH_DISPLAY_INDEX Then
                Help.ShowHelp(hParent, strHelpURL, HelpNavigator.Index)

            ElseIf nCommand = CSH_DISPLAY_SEARCH Then
                Help.ShowHelp(hParent, strHelpURL, HelpNavigator.Find)
            Else
                Return False
            End If
            Return True

        End Function

        Private Function RH_ShowHtmlHelp(ByVal hParent As Object, ByVal strHelpURL As String, ByVal nCommand As Integer, ByVal nData As Integer) As Boolean
            If nCommand = CSH_DISPLAY_CONTEXT Then
                Help.ShowHelp(hParent, strHelpURL, HelpNavigator.TopicId, CStr(nData))
            ElseIf nCommand = CSH_DISPLAY_TOC Then
                Help.ShowHelp(hParent, strHelpURL, HelpNavigator.TableOfContents)
            ElseIf nCommand = CSH_DISPLAY_INDEX Then
                Help.ShowHelp(hParent, strHelpURL, HelpNavigator.Index)
            ElseIf nCommand = CSH_DISPLAY_SEARCH Then
                Help.ShowHelp(hParent, strHelpURL, HelpNavigator.Find)
            Else
                Return False
            End If

            Return True
            Return 1
        End Function

        Private Function RH_ShowWebHelp(ByVal hParent As Object, ByVal strHelpURL As String, ByVal nCommand As Integer, ByVal nData As Integer) As Boolean

            If File.Exists(strHelpURL) = False Then
                Return False
            End If

            '// reset the command
            Select Case nCommand
                Case CSH_DISPLAY_CONTEXT
                    strHelpURL += "#<id=" + CStr(nData)
                Case CSH_DISPLAY_INDEX
                    strHelpURL += "#<cmd=idx"
                Case CSH_DISPLAY_SEARCH
                    strHelpURL += "#<cmd=fts"
                Case CSH_DISPLAY_TOC
                    strHelpURL += "#<cmd=toc"
                Case Else
                    Return False
            End Select
            Return ShowHelpURL(strHelpURL)
        End Function

        Public Function RH_AIR_ShowHelp(ByVal a_pszViewerPath As String, ByVal a_pszHelpId As String, ByVal a_pszWindowName As String, ByVal ulMapNum As Long, ByVal a_pszMapId As String, ByVal a_pszTopicURL As String)

            Dim strCommandLine As String
            Dim bRetVal As Boolean = False
            If (File.Exists(a_pszViewerPath)) Then

                strCommandLine = " -csh"
                If (a_pszHelpId.Length > 0) Then

                    strCommandLine += " helpid """ + a_pszHelpId + " """

                End If
                If (a_pszWindowName.Length > 0) Then

                    strCommandLine += " window """ + a_pszWindowName + " """

                End If

                If (a_pszTopicURL.Length > 0) Then

                    strCommandLine += " topicurl """ + a_pszTopicURL + " """


                ElseIf (a_pszMapId.Length > 0) Then

                    strCommandLine += " mapid """ + a_pszMapId + """"

                Else

                    strCommandLine += " mapnumber " + ulMapNum

                End If

                Try
                    Dim Process As System.Diagnostics.Process
                    Process = New System.Diagnostics.Process
                    Process.StartInfo.UseShellExecute = True
                    Process.Start(a_pszViewerPath, strCommandLine)
                    bRetVal = True
                Catch
                    bRetVal = False
                End Try

            End If
            Return bRetVal

        End Function

        '// dispatch the show help url to IE and others
        Private Function ShowHelpURL(ByVal strURL As String) As Boolean
            Dim m_cExplorer As InternetExplorer = New InternetExplorer
            m_cExplorer = CreateObject("InternetExplorer.Application")
            If IsNothing(m_cExplorer) = 0 Then
                m_cExplorer.Navigate(strURL, vbNull, vbNull, vbNull, vbNull)
                m_cExplorer.Visible = True
            End If
            Return True
        End Function

        Private Function BindParam(ByRef strPage As String, ByVal strTag As String, ByVal strValue As String) As Boolean
            Dim nPos As Integer = 0
            Dim nStart As Integer = 1

            strTag = "<%" + strTag + "%>"
            Dim nTagLen As Integer = strTag.Length
            Dim nValLen As Integer = strValue.Length

            While (True)
                nPos = strPage.IndexOf(strTag, nStart)
                If nPos <= 0 Then
                    Exit While
                End If
                strPage = strPage.Remove(nPos, nTagLen)
                strPage = strPage.Insert(nPos, strValue)
                nStart = nPos + nValLen
            End While

            Return True
        End Function

        Private Function BindParam(ByRef strPage As String, ByVal strTag As String, ByVal bValue As Boolean) As Boolean
            Dim strValue As String

            If bValue Then
                strValue = "1"
            Else
                strValue = "0"
            End If
            Return BindParam(strPage, strTag, strValue)

        End Function

    End Class

    ''' <summary>
    ''' Class to Search the Project for a Query in a project
    ''' The search results include the Rank, Title, URL and summary about the resulting topic
    ''' 
    ''' The class contains a function to Search the Web Help Pro and Flash Help Pro
    ''' projects hosted on the RoboHelp Server specified
    ''' 
    ''' Public Function RH_SearchHelpPro( serverName As String, projectType As Integer, projectName As String, strQuestion As String, strArea As String) As Boolean
    ''' 
    ''' serverName
    '''        URL to the RoboHelp Server ("http://www.myurl.com/robohelp/rest")
    ''' 
    ''' projectType
    '''         specifying the type of project
    '''           WEB_HELP_PRO
    '''           FLASH_HELP_PRO
    ''' 
    ''' projectName
    '''         specifying the project to search 
    ''' 
    ''' strQuestion
    '''         the query string to search
    ''' 
    ''' strArea
    '''         the area where the project is published in
    ''' 
    ''' </summary>
    ''' <remarks></remarks>

    Public Class RoboHelp_Search
        Public Const WEB_HELP As Integer = 1
        Public Const FLASH_HELP As Integer = 2
        Dim url As String
        Dim HttpReq As New MSXML2.XMLHTTP60
        Dim objDoc As New MSXML2.DOMDocument60
        Dim objNodeList As MSXML2.IXMLDOMNodeList
        Dim objNode, attrNode As MSXML2.IXMLDOMNode
        Dim namedNodeMap As MSXML2.IXMLDOMNamedNodeMap
        Public strRank(), strTitle(), strURL(), strSummary() As String
        Public nResponseCount As Integer

        '//////////////////////////////////////////////////////////////////////////////
        '//	This function creates an URL from the input provided by the application
        '//	and then sends it to the server through an xmlhttp request
        '//	
        '// the expected format for searching is
        '// "http://<servername>/robohelp/rest/search?project=<project-name>&quesn=<search-query>"

        '//	The response is returned by the server in an XML format
        '//	the schema of the response xml file is
        '//
        '////// <?xml version="1.0" encoding "utf-8" ?>
        '////// <ftstdata>
        '////// <topic name="{topic-name}" url="{url of topic}" summary="{summary}" 
        '//////		  rank="{rank}" />
        '////// </ftstdata>
        '//
        '////    The XML file is parsed and the values are then stored in the arrays 
        '////    specific to Rank, Title, URL and Summary
        '//////////////////////////////////////////////////////////////////////////////

        Public Function RH_SearchHelpPro(ByVal serverName As String, ByVal projectType As Integer, ByVal projectName As String, ByVal strQuestion As String, ByVal strArea As String) As Boolean

            Dim strXmlFormat As String
            Dim strXmlRequest As String
            url = "http://" + serverName + "/search"

            HttpReq.open("POST", url, False)
            strXmlFormat = "<?xml version=""1.0"" encoding=""utf-8"" ?><rest><UID name=""{0}"" /><PWD name=""{1}"" /><PRJ name=""{2}"" /><AREA name=""{3}"" /><QUESN name=""{4}"" />"
            strXmlRequest = String.Format(strXmlFormat, "admin", "admin", projectName, strArea, strQuestion)
            If (projectType = FLASH_HELP) Then
                strXmlRequest += "<TYPE name=""flashhelp""/>"
            End If
            strXmlRequest += "</rest>"
            HttpReq.send(strXmlRequest)

            If (Not HttpReq.status = 200) Then
                MsgBox("Unable to get Response from Server")
                Return False
            End If
            MsgBox(HttpReq.responseText)

            nResponseCount = 0
            If objDoc.loadXML(HttpReq.responseText) Then
                objNodeList = objDoc.getElementsByTagName("topic")
                nResponseCount = objNodeList.length
                Dim str = "The node list has " & objNodeList.length & _
                 " items."
                Dim x As Long

                ReDim strTitle(nResponseCount)
                ReDim strRank(nResponseCount)
                ReDim strURL(nResponseCount)
                ReDim strSummary(nResponseCount)

                x = 1
                For x = 1 To objNodeList.length
                    objNode = objNodeList.nextNode
                    namedNodeMap = objNode.attributes
                    attrNode = namedNodeMap.getNamedItem("name")
                    strTitle(x) = attrNode.text

                    attrNode = namedNodeMap.getNamedItem("rank")
                    strRank(x) = attrNode.text

                    attrNode = namedNodeMap.getNamedItem("url")
                    strURL(x) = attrNode.text

                    attrNode = namedNodeMap.getNamedItem("summary")
                    strSummary(x) = attrNode.text

                Next

                Return True

            End If

            Return False

        End Function

    End Class

End Namespace