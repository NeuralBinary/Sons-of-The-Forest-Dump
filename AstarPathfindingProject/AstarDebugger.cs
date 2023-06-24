using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[AddComponentMenu("Pathfinding/Pathfinding Debugger")]
	[ExecuteInEditMode]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_astar_debugger.php")]
	public class AstarDebugger : VersionedMonoBehaviour
	{
		// Token: 0x060002DE RID: 734 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x644F10", Offset = "0x643510", VA = "0x180644F10")]
		public void Start()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x645320", Offset = "0x643920", VA = "0x180645320")]
		public void LateUpdate()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x645CE0", Offset = "0x6442E0", VA = "0x180645CE0")]
		private void DrawGraphLine(int index, Matrix4x4 m, float x1, float x2, float y1, float y2, Color color)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x6460E0", Offset = "0x6446E0", VA = "0x1806460E0")]
		public void OnGUI()
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x647DB0", Offset = "0x6463B0", VA = "0x180647DB0")]
		public AstarDebugger()
		{
		}

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x28")]
		public int yOffset;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x2C")]
		public bool show;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x2D")]
		public bool showInEditor;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x2E")]
		public bool showFPS;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x2F")]
		public bool showPathProfile;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x30")]
		public bool showMemProfile;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x31")]
		public bool showGraph;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x34")]
		public int graphBufferSize;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x38")]
		public Font font;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x40")]
		public int fontSize;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x48")]
		private StringBuilder text;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x50")]
		private string cachedText;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x58")]
		private float lastUpdate;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x60")]
		private AstarDebugger.GraphPoint[] graph;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x68")]
		private float delayedDeltaTime;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x6C")]
		private float lastCollect;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x70")]
		private float lastCollectNum;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x74")]
		private float delta;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x78")]
		private float lastDeltaTime;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x7C")]
		private int allocRate;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x80")]
		private int lastAllocMemory;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x84")]
		private float lastAllocSet;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x88")]
		private int allocMem;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x8C")]
		private int collectAlloc;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x90")]
		private int peakAlloc;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x94")]
		private int fpsDropCounterSize;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x98")]
		private float[] fpsDrops;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0xA0")]
		private Rect boxRect;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0xB0")]
		private GUIStyle style;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0xB8")]
		private Camera cam;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0xC0")]
		private float graphWidth;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0xC4")]
		private float graphHeight;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0xC8")]
		private float graphOffset;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0xCC")]
		private int maxVecPool;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0xD0")]
		private int maxNodePool;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0xD8")]
		private AstarDebugger.PathTypeDebug[] debugTypes;

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		private struct GraphPoint
		{
			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000206")]
			[FieldOffset(Offset = "0x0")]
			public float fps;

			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000207")]
			[FieldOffset(Offset = "0x4")]
			public float memory;

			// Token: 0x04000208 RID: 520
			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x8")]
			public bool collectEvent;
		}

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x200004F")]
		private struct PathTypeDebug
		{
			// Token: 0x060002E3 RID: 739 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x649120", Offset = "0x647720", VA = "0x180649120")]
			public PathTypeDebug(string name, Func<int> getSize, Func<int> getTotalCreated)
			{
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x649240", Offset = "0x647840", VA = "0x180649240")]
			public void Print(StringBuilder text)
			{
			}

			// Token: 0x04000209 RID: 521
			[Token(Token = "0x4000209")]
			[FieldOffset(Offset = "0x0")]
			private string name;

			// Token: 0x0400020A RID: 522
			[Token(Token = "0x400020A")]
			[FieldOffset(Offset = "0x8")]
			private Func<int> getSize;

			// Token: 0x0400020B RID: 523
			[Token(Token = "0x400020B")]
			[FieldOffset(Offset = "0x10")]
			private Func<int> getTotalCreated;
		}
	}
}
