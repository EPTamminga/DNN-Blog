Imports System
Imports System.Runtime.Serialization

Namespace Entities.Blogs
 Partial Public Class BlogInfo

#Region " Private Members "
#End Region

#Region " Constructors "
  Public Sub New()
   Try
    Locale = DotNetNuke.Entities.Portals.PortalSettings.Current.DefaultLanguage
   Catch ex As Exception
   End Try
  End Sub
#End Region

#Region " Public Properties "
  <DataMember()>
  Public Property BlogID As Int32 = -1
  <DataMember()>
  Public Property ModuleID As Int32 = -1
  <DataMember()>
  Public Property Title As String = ""
  <DataMember()>
  Public Property Description As String = ""
  <DataMember()>
  Public Property Image As String = ""
  <DataMember()>
  Public Property Locale As String = ""
  <DataMember()>
  Public Property Published As Boolean = True
  <DataMember()>
  Public Property IncludeImagesInFeed As Boolean = True
  <DataMember()>
  Public Property IncludeAuthorInFeed As Boolean = False
  <DataMember()>
  Public Property AllowComments As Boolean = True
  <DataMember()>
  Public Property AllowAnonymousComments As Boolean = False
  <DataMember()>
  Public Property Syndicated As Boolean = True
  <DataMember()>
  Public Property SyndicationEmail As String = ""
  <DataMember()>
  Public Property Copyright As String = ""
  <DataMember()>
  Public Property MustApproveGhostPosts As Boolean = False
  <DataMember()>
  Public Property PublishAsOwner As Boolean = False
  <DataMember()>
  Public Property OwnerUserId As Int32 = -1
  <DataMember()>
  Public Property CreatedByUserID As Int32 = -1
  <DataMember()>
  Public Property CreatedOnDate As Date = Date.MinValue
  <DataMember()>
  Public Property LastModifiedByUserID As Int32 = -1
  <DataMember()>
  Public Property LastModifiedOnDate As Date = Date.MinValue
  <DataMember()>
  Public Property Username As String = ""
  <DataMember()>
  Public Property DisplayName As String = ""
  <DataMember()>
  Public Property Email As String = ""
#End Region

#Region " ML Properties "
  <DataMember()>
  Public Property AltLocale As String = ""
  <DataMember()>
  Public Property AltTitle As String = ""
  <DataMember()>
  Public Property AltDescription As String = ""

  Public ReadOnly Property LocalizedTitle As String
   Get
    Return CStr(IIf(String.IsNullOrEmpty(AltTitle), Title, AltTitle))
   End Get
  End Property

  Public ReadOnly Property LocalizedDescription As String
   Get
    Return CStr(IIf(String.IsNullOrEmpty(AltDescription), Description, AltDescription))
   End Get
  End Property
#End Region

 End Class
End Namespace


