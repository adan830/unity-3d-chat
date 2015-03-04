using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {

	
	
	void OnClick()
	{
		 //得到item自对象的精灵组建。
		 //因为得到的组建采取深度优先
		 //所以我们需要修改数组中元素为1的精灵
		 //数组中元素为0的精灵是按钮的背景
		 UISprite ui = GetComponentsInChildren<UISprite>()[1];
		 //修改头像为女生头像
		 ui.spriteName = "icon1";
		
		 //得到文字对象
		 UILabel label = GetComponentInChildren<UILabel>();
		 //修改文字内容
		 label.text = "若若";
	}
}
