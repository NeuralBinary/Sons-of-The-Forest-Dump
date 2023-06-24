using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Assemblies.Sons.Cinematics
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[AddComponentMenu("Sons/Cinematics/Title Helicopter Controller")]
	public class SonsTitleHelicopterController : MonoBehaviour
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2D57D50", Offset = "0x2D56350", VA = "0x182D57D50")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2D58020", Offset = "0x2D56620", VA = "0x182D58020")]
		public SonsTitleHelicopterController()
		{
		}

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _flySpeed;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _directionTransform;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _resetHelicopterPositionAt;
	}
}
