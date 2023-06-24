using System;
using Crest.Spline;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[AddComponentMenu("")]
	public class SplinePointDataFoam : MonoBehaviour, ISplinePointCustomData
	{
		// Token: 0x06000206 RID: 518 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x9FE4C0", Offset = "0x9FCAC0", VA = "0x1809FE4C0", Slot = "4")]
		public Vector2 GetData()
		{
			return default(Vector2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x9FE530", Offset = "0x9FCB30", VA = "0x1809FE530")]
		public SplinePointDataFoam()
		{
		}

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private int _version;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Amount of foam emitted.")]
		private float _foamAmount;
	}
}
