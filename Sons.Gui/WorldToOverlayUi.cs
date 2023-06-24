using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public class WorldToOverlayUi : MonoBehaviour
	{
		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x30216D0", Offset = "0x301FCD0", VA = "0x1830216D0")]
		private void Start()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x30217A0", Offset = "0x301FDA0", VA = "0x1830217A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x3021DC0", Offset = "0x30203C0", VA = "0x183021DC0")]
		private Camera GetCamera()
		{
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WorldToOverlayUi()
		{
		}

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _target;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _baseScale;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		private const string SceneCameraName = "SceneCamera";
	}
}
