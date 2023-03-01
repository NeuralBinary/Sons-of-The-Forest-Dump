using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x0200088A RID: 2186
	[Token(Token = "0x200088A")]
	[Serializable]
	public class ControllerNodeInfo
	{
		// Token: 0x06003B19 RID: 15129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x2EF9AC0", Offset = "0x2EF8AC0", VA = "0x182EF9AC0")]
		public ControllerNodeInfo(string name, string path, AnimationClip clip, NodeType nodeType, [Optional] string clipPath)
		{
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x2EF99C0", Offset = "0x2EF89C0", VA = "0x182EF99C0")]
		public void Add(ControllerNodeInfo controllerNodeInfo)
		{
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06003B1B RID: 15131 RVA: 0x00011370 File Offset: 0x0000F570
		[Token(Token = "0x17000730")]
		private bool IsClipType
		{
			[Token(Token = "0x6003B1B")]
			[Address(RVA = "0x2EF9C20", Offset = "0x2EF8C20", VA = "0x182EF9C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x00011388 File Offset: 0x0000F588
		[Token(Token = "0x17000731")]
		private Color GetGuiColor
		{
			[Token(Token = "0x6003B1C")]
			[Address(RVA = "0x2EF9B50", Offset = "0x2EF8B50", VA = "0x182EF9B50")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B1D")]
		[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220")]
		public List<ControllerNodeInfo> GetNodes()
		{
			return null;
		}

		// Token: 0x04003F76 RID: 16246
		[Token(Token = "0x4003F76")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private NodeType _nodeType;

		// Token: 0x04003F77 RID: 16247
		[Token(Token = "0x4003F77")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		// Token: 0x04003F78 RID: 16248
		[Token(Token = "0x4003F78")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _path;

		// Token: 0x04003F79 RID: 16249
		[Token(Token = "0x4003F79")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationClip _clip;

		// Token: 0x04003F7A RID: 16250
		[Token(Token = "0x4003F7A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _clipPath;

		// Token: 0x04003F7B RID: 16251
		[Token(Token = "0x4003F7B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ControllerNodeInfo> _subNodes;
	}
}
