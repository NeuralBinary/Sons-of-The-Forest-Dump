using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001FE RID: 510
	[Token(Token = "0x20001FE")]
	[AddComponentMenu("Physics/Obi/Obi Rope Chain Renderer", 885)]
	[ExecuteInEditMode]
	public class ObiRopeChainRenderer : MonoBehaviour
	{
		// Token: 0x06000A6F RID: 2671 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x281CE40", Offset = "0x281B440", VA = "0x18281CE40")]
		private void Awake()
		{
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0000566C File Offset: 0x0000386C
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170001AB")]
		public bool RandomizeLinks
		{
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x281CE50", Offset = "0x281B450", VA = "0x18281CE50")]
			set
			{
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x281CEB0", Offset = "0x281B4B0", VA = "0x18281CEB0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x281CF60", Offset = "0x281B560", VA = "0x18281CF60")]
		private void OnDisable()
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x281D010", Offset = "0x281B610", VA = "0x18281D010")]
		public void ClearChainLinkInstances()
		{
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x281D1D0", Offset = "0x281B7D0", VA = "0x18281D1D0")]
		public void CreateChainLinkInstances(ObiRopeBase rope)
		{
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x281D430", Offset = "0x281BA30", VA = "0x18281D430")]
		public void UpdateRenderer(ObiActor actor)
		{
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x281E170", Offset = "0x281C770", VA = "0x18281E170")]
		public ObiRopeChainRenderer()
		{
		}

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_UpdateChainRopeRendererChunksPerfMarker;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		public List<GameObject> linkInstances;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[SerializeProperty("RandomizeLinks")]
		private bool randomizeLinks;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 linkScale;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x38")]
		public List<GameObject> linkPrefabs;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float twistAnchor;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x44")]
		public float sectionTwist;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x48")]
		private ObiPathFrame frame;
	}
}
