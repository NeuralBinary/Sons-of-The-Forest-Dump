using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui.Input
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[AddComponentMenu("Sons/Gui/Input/MirrorUiRawImageTexture")]
	public class MirrorUiRawImageTexture : MonoBehaviour
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x305D660", Offset = "0x305BC60", VA = "0x18305D660")]
		private void LateUpdate()
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MirrorUiRawImageTexture()
		{
		}

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage _source;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RawImage _target;
	}
}
