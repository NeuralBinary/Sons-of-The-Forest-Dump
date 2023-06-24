using System;
using Crest.Spline;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[AddComponentMenu("")]
	public class SplinePointDataGerstner : MonoBehaviour, ISplinePointCustomData
	{
		// Token: 0x06000208 RID: 520 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x9FE4C0", Offset = "0x9FCAC0", VA = "0x1809FE4C0", Slot = "4")]
		public Vector2 GetData()
		{
			return default(Vector2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x9FE530", Offset = "0x9FCB30", VA = "0x1809FE530")]
		public SplinePointDataGerstner()
		{
		}

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private int _version;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Weight multiplier to scale waves.")]
		[SerializeField]
		private float _weight;
	}
}
