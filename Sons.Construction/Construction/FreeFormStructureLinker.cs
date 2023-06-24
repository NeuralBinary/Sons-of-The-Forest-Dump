using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	[AddComponentMenu("Sons/Construction/FreeFormStructureLinker")]
	public abstract class FreeFormStructureLinker : MonoBehaviour
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000250")]
		public Structure SupportingStructure
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x2E4F2D0", Offset = "0x2E4D8D0", VA = "0x182E4F2D0")]
		public void SetSupportingStructure(Structure supportingStructure)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2E4F380", Offset = "0x2E4D980", VA = "0x182E4F380")]
		private void Awake()
		{
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x2E4F520", Offset = "0x2E4DB20", VA = "0x182E4F520")]
		private void OnDestroy()
		{
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x2E4F6D0", Offset = "0x2E4DCD0", VA = "0x182E4F6D0")]
		[UsedImplicitly]
		private void OnPlacedStructure()
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected FreeFormStructureLinker()
		{
		}

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Structure _supportingStructure;
	}
}
