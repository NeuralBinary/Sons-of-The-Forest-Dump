using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public abstract class AutoUpdateTextMesh : MonoBehaviour
	{
		// Token: 0x06000027 RID: 39
		[Token(Token = "0x6000027")]
		public abstract string GetString();

		// Token: 0x06000028 RID: 40
		[Token(Token = "0x6000028")]
		public abstract bool CanUpdate();

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3000630", Offset = "0x2FFEC30", VA = "0x183000630")]
		internal void DoUpdate()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected AutoUpdateTextMesh()
		{
		}

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Text _target;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _prefix;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _suffix;
	}
}
