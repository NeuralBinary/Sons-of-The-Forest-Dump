using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.VFX;

namespace Sons.VFX
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class VFXEventTrigger : MonoBehaviour
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x3178C40", Offset = "0x3177240", VA = "0x183178C40")]
		private void TriggerFX()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VFXEventTrigger()
		{
		}

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("vfxGraphObj")]
		[SerializeField]
		private VisualEffect _vfxGraphObj;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _eventName;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x30")]
		private int _eventNameCache;
	}
}
