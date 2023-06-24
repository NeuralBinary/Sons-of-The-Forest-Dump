using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000203 RID: 515
	[Token(Token = "0x2000203")]
	[RequireComponent(typeof(ObiRope))]
	[RequireComponent(typeof(ObiPathSmoother))]
	public class ObiRopePrefabPlugger : MonoBehaviour
	{
		// Token: 0x06000A9B RID: 2715 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x2824B70", Offset = "0x2823170", VA = "0x182824B70")]
		private void OnEnable()
		{
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x2824D00", Offset = "0x2823300", VA = "0x182824D00")]
		private void OnDisable()
		{
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x2824F00", Offset = "0x2823500", VA = "0x182824F00")]
		private GameObject GetOrCreatePrefabInstance(int index)
		{
			return null;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x2825040", Offset = "0x2823640", VA = "0x182825040")]
		public void ClearPrefabInstances()
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x28251D0", Offset = "0x28237D0", VA = "0x1828251D0")]
		private void UpdatePlugs(ObiActor actor)
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x2825BF0", Offset = "0x28241F0", VA = "0x182825BF0")]
		public ObiRopePrefabPlugger()
		{
		}

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0x20")]
		public GameObject prefab;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 instanceScale;

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x34")]
		public bool plugTears;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0x35")]
		public bool plugStart;

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0x36")]
		public bool plugEnd;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0x38")]
		private List<GameObject> instances;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0x40")]
		private ObiPathSmoother smoother;
	}
}
