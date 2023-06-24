using System;
using Crest.Spline;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[AddComponentMenu("")]
	public class SplinePointDataFlow : MonoBehaviour, ISplinePointCustomData
	{
		// Token: 0x06000204 RID: 516 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x9FE4C0", Offset = "0x9FCAC0", VA = "0x1809FE4C0", Slot = "4")]
		public Vector2 GetData()
		{
			return default(Vector2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x9FE4E0", Offset = "0x9FCAE0", VA = "0x1809FE4E0")]
		public SplinePointDataFlow()
		{
		}

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private int _version;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		public const float k_defaultSpeed = 2f;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Flow velocity (speed of flow in direction of spline). Can be negative to flip direction.")]
		[SerializeField]
		private float _flowVelocity;
	}
}
