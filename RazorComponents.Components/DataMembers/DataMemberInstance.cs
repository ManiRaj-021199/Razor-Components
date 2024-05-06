namespace RazorComponents.Components;

public static class DataMemberInstance
{
    #region Publics
    public static DataMember GetDataMember(this object objMember, string strPropertyName)
    {
        return new DataMember(objMember, strPropertyName);
    }
    #endregion
}