using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.RVO;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	[RequireComponent(typeof(MeshFilter))]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_lightweight_r_v_o.php")]
	public class LightweightRVO : MonoBehaviour
	{
		// Token: 0x06000B4E RID: 2894 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x72DDF0", Offset = "0x72C3F0", VA = "0x18072DDF0")]
		public void Start()
		{
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x72E160", Offset = "0x72C760", VA = "0x18072E160")]
		public void OnGUI()
		{
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00006D4C File Offset: 0x00004F4C
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x72E4D0", Offset = "0x72CAD0", VA = "0x18072E4D0")]
		private float uniformDistance(float radius)
		{
			return 0f;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x72E5B0", Offset = "0x72CBB0", VA = "0x18072E5B0")]
		public void CreateAgents(int num)
		{
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x72FA30", Offset = "0x72E030", VA = "0x18072FA30")]
		private void SetAgentSettings()
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x72FD60", Offset = "0x72E360", VA = "0x18072FD60")]
		public void Update()
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x731210", Offset = "0x72F810", VA = "0x180731210")]
		public LightweightRVO()
		{
		}

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x20")]
		public int agentCount;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x24")]
		public float exampleScale;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x28")]
		public LightweightRVO.RVOExampleType type;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x2C")]
		public float radius;

		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x30")]
		public float maxSpeed;

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x34")]
		public float agentTimeHorizon;

		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public float obstacleTimeHorizon;

		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x3C")]
		public int maxNeighbours;

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 renderingOffset;

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x4C")]
		public bool debug;

		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		[FieldOffset(Offset = "0x50")]
		private Mesh mesh;

		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x58")]
		private Simulator sim;

		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x60")]
		private List<IAgent> agents;

		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x68")]
		private List<Vector3> goals;

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x70")]
		private List<Color> colors;

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] verts;

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x80")]
		private Vector2[] uv;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x88")]
		private int[] tris;

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x90")]
		private Color[] meshColors;

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x98")]
		private Vector2[] interpolatedVelocities;

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0xA0")]
		private Vector2[] interpolatedRotations;

		// Token: 0x02000167 RID: 359
		[Token(Token = "0x2000167")]
		public enum RVOExampleType
		{
			// Token: 0x04000807 RID: 2055
			[Token(Token = "0x4000807")]
			Circle,
			// Token: 0x04000808 RID: 2056
			[Token(Token = "0x4000808")]
			Line,
			// Token: 0x04000809 RID: 2057
			[Token(Token = "0x4000809")]
			Point,
			// Token: 0x0400080A RID: 2058
			[Token(Token = "0x400080A")]
			RandomStreams,
			// Token: 0x0400080B RID: 2059
			[Token(Token = "0x400080B")]
			Crossing
		}
	}
}
