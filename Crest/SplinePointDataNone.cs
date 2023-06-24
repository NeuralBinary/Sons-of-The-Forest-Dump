using System;
using Crest.Spline;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[AddComponentMenu("")]
	public class SplinePointDataNone : MonoBehaviour, ISplinePointCustomData
	{
		// Token: 0x0600020A RID: 522 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x5BC460", Offset = "0x5BAA60", VA = "0x1805BC460", Slot = "4")]
		public Vector2 GetData()
		{
			return default(Vector2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SplinePointDataNone()
		{
		}

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private int _version;
	}
}
