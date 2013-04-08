Imports System
Imports System.Runtime.Serialization

Namespace Entities.Posts
  Partial Public Class PostInfo
  Inherits DotNetNuke.Entities.Content.ContentItem

#Region " Private Members "
#End Region

#Region " Constructors "
  Public Sub New()
  End Sub
#End Region

#Region " Public Properties "
  <DataMember()>
  Public Property BlogID As Int32 = -1
  <DataMember()>
  Public Property Title As String = ""
  <DataMember()>
  Public Property Summary As String = ""
  <DataMember()>
  Public Property Image As String = ""
  <DataMember()>
  Public Property Published As Boolean = True
  <DataMember()>
  Public Property PublishedOnDate As Date = Date.Now.ToUniversalTime
  <DataMember()>
  Public Property AllowComments As Boolean = True
  <DataMember()>
  Public Property DisplayCopyright As Boolean = False
  <DataMember()>
  Public Property Copyright As String = ""
  <DataMember()>
  Public Property Locale As String = ""
  <DataMember()>
  Public Property ViewCount As Int32 = 0
  <DataMember()>
  Public Property TranslationOf As Int32 = -1
  <DataMember()>
  Public Property Username As String = ""
  <DataMember()>
  Public Property Email As String = ""
  <DataMember()>
  Public Property DisplayName As String = ""
#End Region

#Region " ML Properties "
  <DataMember()>
  Public Property AltLocale As String = ""
  <DataMember()>
  Public Property AltTitle As String = ""
  <DataMember()>
  Public Property AltSummary As String = ""

  Public ReadOnly Property LocalizedTitle As String
   Get
    Return CStr(IIf(String.IsNullOrEmpty(AltTitle), Title, AltTitle))
   End Get
  End Property

  Public ReadOnly Property LocalizedSummary As String
   Get
    Return CStr(IIf(String.IsNullOrEmpty(AltSummary), Summary, AltSummary))
   End Get
  End Property
#End Region

 End Class
End Namespace


