using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BoltInternal
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public interface IDebugDrawer
	{
		// Token: 0x06000355 RID: 853
		[Token(Token = "0x6000355")]
		void IsEditor(bool isEditor);

		// Token: 0x06000356 RID: 854
		[Token(Token = "0x6000356")]
		void Indent(int adjust);

		// Token: 0x06000357 RID: 855
		[Token(Token = "0x6000357")]
		void Label(string text);

		// Token: 0x06000358 RID: 856
		[Token(Token = "0x6000358")]
		void LabelBold(string text);

		// Token: 0x06000359 RID: 857
		[Token(Token = "0x6000359")]
		void LabelField(string text, object value);

		// Token: 0x0600035A RID: 858
		[Token(Token = "0x600035A")]
		void Separator();

		// Token: 0x0600035B RID: 859
		[Token(Token = "0x600035B")]
		void SelectGameObject(GameObject gameObject);
	}
}
