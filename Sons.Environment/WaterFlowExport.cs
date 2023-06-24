using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class WaterFlowExport : MonoBehaviour
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WaterFlowExport()
		{
		}

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RamSpline _sourceSpline;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _targetGameObject;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material _materialTemplate;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _name;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _outputFolder;
	}
}
