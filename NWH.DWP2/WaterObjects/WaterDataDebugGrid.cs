using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class WaterDataDebugGrid : MonoBehaviour
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x26FD310", Offset = "0x26FB910", VA = "0x1826FD310")]
		private void Start()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x26FD630", Offset = "0x26FBC30", VA = "0x1826FD630")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x26FD6A0", Offset = "0x26FBCA0", VA = "0x1826FD6A0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WaterDataDebugGrid()
		{
		}

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		private const int GRID_WIDTH = 10;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		private const int GRID_SIZE = 100;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		private Vector3[] _positions;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		private float[] _waterHeights;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x30")]
		private Vector3[] _waterFlows;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x38")]
		private Vector3[] _waterNormals;
	}
}
