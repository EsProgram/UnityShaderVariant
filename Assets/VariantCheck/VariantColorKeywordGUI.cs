using System.Collections;
using UnityEngine;

public class VariantColorKeywordGUI : MonoBehaviour
{
  public void OnGUI()
  {
    KeywordButtonGUI("RED");
    KeywordButtonGUI("GREEN");
    KeywordButtonGUI("BLUE");
  }

  private void KeywordButtonGUI(string keyword)
  {
    if(GUILayout.Button(keyword + " : ON"))
      Shader.EnableKeyword(keyword);
    if(GUILayout.Button(keyword + " : OFF"))
      Shader.DisableKeyword(keyword);
    GUILayout.Label(keyword + " Enabled : " + Shader.IsKeywordEnabled(keyword).ToString());
  }
}