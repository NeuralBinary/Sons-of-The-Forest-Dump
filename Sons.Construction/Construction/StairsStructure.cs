using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000222 RID: 546
	[Token(Token = "0x2000222")]
	[AddComponentMenu("Sons/Construction/StairsStructure")]
	public class StairsStructure : RampStructure, ISolarPanelSupport, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003CC")]
		public new static Counter Counter
		{
			[Token(Token = "0x6001058")]
			[Address(RVA = "0x2F116E0", Offset = "0x2F0FCE0", VA = "0x182F116E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00009EE4 File Offset: 0x000080E4
		[Token(Token = "0x170003CD")]
		public override ushort TypeID
		{
			[Token(Token = "0x6001059")]
			[Address(RVA = "0x9FA5F0", Offset = "0x9F8BF0", VA = "0x1809FA5F0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00009EFC File Offset: 0x000080FC
		[Token(Token = "0x600105A")]
		[Address(RVA = "0x2D83E20", Offset = "0x2D82420", VA = "0x182D83E20", Slot = "125")]
		protected override Vector3 GetElementUpAxis()
		{
			return default(Vector3);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00009F14 File Offset: 0x00008114
		[Token(Token = "0x600105B")]
		[Address(RVA = "0x2F11730", Offset = "0x2F0FD30", VA = "0x182F11730")]
		private float CalcSupportLength()
		{
			return 0f;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00009F2C File Offset: 0x0000812C
		[Token(Token = "0x600105C")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "114")]
		private bool CanHostNewSolarPanel()
		{
			return default(bool);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600105D")]
		[Address(RVA = "0x2F11780", Offset = "0x2F0FD80", VA = "0x182F11780")]
		public StairsStructure()
		{
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600105F")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00009F44 File Offset: 0x00008144
		[Token(Token = "0x6001062")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}
	}
}
