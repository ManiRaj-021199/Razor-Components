namespace RazorComponents.Components;

public class DataMember
{
    #region Fields
    private readonly object _objMember;
    private readonly string _strPropertyName;
    #endregion

    #region Constructors
    internal DataMember(object objMember, string strPropertyName)
    {
        _objMember = objMember;
        _strPropertyName = strPropertyName;
    }
    #endregion

    #region Internals
    internal void SetMemberValue(string strValue)
    {
        _objMember.GetType().GetProperty(_strPropertyName)?.SetValue(_objMember, strValue, null);
    }
    #endregion
}