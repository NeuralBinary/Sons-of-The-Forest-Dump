using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	[ExecuteInEditMode]
	public class ObiStitcher : MonoBehaviour
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000158")]
		public ObiActor Actor1
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x27FEEB0", Offset = "0x27FD4B0", VA = "0x1827FEEB0")]
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000159")]
		public ObiActor Actor2
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x27FF040", Offset = "0x27FD640", VA = "0x1827FF040")]
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00004B8C File Offset: 0x00002D8C
		[Token(Token = "0x1700015A")]
		public int StitchCount
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x27FF1D0", Offset = "0x27FD7D0", VA = "0x1827FF1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700015B")]
		public IEnumerable<ObiStitcher.Stitch> Stitches
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x27FF210", Offset = "0x27FD810", VA = "0x1827FF210")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x27FF2D0", Offset = "0x27FD8D0", VA = "0x1827FF2D0")]
		private void RegisterActor(ObiActor actor)
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x27FF4E0", Offset = "0x27FDAE0", VA = "0x1827FF4E0")]
		private void UnregisterActor(ObiActor actor)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x27FF7B0", Offset = "0x27FDDB0", VA = "0x1827FF7B0")]
		public void OnEnable()
		{
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x27FF7E0", Offset = "0x27FDDE0", VA = "0x1827FF7E0")]
		public void OnDisable()
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x27FF810", Offset = "0x27FDE10", VA = "0x1827FF810")]
		public int AddStitch(int particle1, int particle2)
		{
			return 0;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x27FF8F0", Offset = "0x27FDEF0", VA = "0x1827FF8F0")]
		public void RemoveStitch(int index)
		{
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x27FF960", Offset = "0x27FDF60", VA = "0x1827FF960")]
		public void Clear()
		{
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x27FF9D0", Offset = "0x27FDFD0", VA = "0x1827FF9D0")]
		private void Actor_OnBlueprintUnloaded(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x27FFAE0", Offset = "0x27FE0E0", VA = "0x1827FFAE0")]
		private void Actor_OnBlueprintLoaded(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x27FFEF0", Offset = "0x27FE4F0", VA = "0x1827FFEF0")]
		private void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x2800070", Offset = "0x27FE670", VA = "0x182800070")]
		private void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x2800170", Offset = "0x27FE770", VA = "0x182800170")]
		public void PushDataToSolver()
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x2800BF0", Offset = "0x27FF1F0", VA = "0x182800BF0")]
		public ObiStitcher()
		{
		}

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private List<ObiStitcher.Stitch> stitches;

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private ObiActor actor1;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private ObiActor actor2;

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public ObiNativeIntList particleIndices;

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public ObiNativeFloatList stiffnesses;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeFloatList lambdas;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x50")]
		private IStitchConstraintsBatchImpl m_BatchImpl;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x58")]
		private bool inSolver;

		// Token: 0x020001CD RID: 461
		[Token(Token = "0x20001CD")]
		[Serializable]
		public class Stitch
		{
			// Token: 0x06000902 RID: 2306 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1F436F0", Offset = "0x1F41CF0", VA = "0x181F436F0")]
			public Stitch(int particleIndex1, int particleIndex2)
			{
			}

			// Token: 0x0400078F RID: 1935
			[Token(Token = "0x400078F")]
			[FieldOffset(Offset = "0x10")]
			public int particleIndex1;

			// Token: 0x04000790 RID: 1936
			[Token(Token = "0x4000790")]
			[FieldOffset(Offset = "0x14")]
			public int particleIndex2;
		}
	}
}
