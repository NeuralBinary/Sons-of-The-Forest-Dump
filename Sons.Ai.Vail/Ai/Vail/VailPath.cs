using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	[AddComponentMenu("Sons/Ai/Vail Path")]
	public class VailPath : MonoBehaviour
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00005AD8 File Offset: 0x00003CD8
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000080")]
		public bool IgnorePathBounds
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x9C5820", Offset = "0x9C3E20", VA = "0x1809C5820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2B66130", Offset = "0x2B64730", VA = "0x182B66130")]
		public void SetKeepAboveTerrain(bool value)
		{
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x2B66140", Offset = "0x2B64740", VA = "0x182B66140")]
		private void OnValidate()
		{
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2B66270", Offset = "0x2B64870", VA = "0x182B66270")]
		public int GetPathPointsCount()
		{
			return 0;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x2B662B0", Offset = "0x2B648B0", VA = "0x182B662B0")]
		public Vector3 GetPathPointAtIndex(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x2B66370", Offset = "0x2B64970", VA = "0x182B66370")]
		public void CreateStraightPath(Vector3 start, Vector3 end)
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x2B664F0", Offset = "0x2B64AF0", VA = "0x182B664F0")]
		public void ClearStraightPath()
		{
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x2B66540", Offset = "0x2B64B40", VA = "0x182B66540")]
		public Vector3 ValidatePosition(Vector3 result)
		{
			return default(Vector3);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2B666F0", Offset = "0x2B64CF0", VA = "0x182B666F0")]
		private Vector3 ClampPosition(Vector3 targetPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2B66830", Offset = "0x2B64E30", VA = "0x182B66830")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2B66AC0", Offset = "0x2B650C0", VA = "0x182B66AC0")]
		public VailPath()
		{
		}

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _clampToBounds;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _keepAboveTerrain;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailActor _actor;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _terrainOffsetMin;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<Vector3> _straightPath;
	}
}
