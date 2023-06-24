using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[AddComponentMenu("Pathfinding/GraphUpdateScene")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_graph_update_scene.php")]
	public class GraphUpdateScene : GraphModifier
	{
		// Token: 0x060002BE RID: 702 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x63F9C0", Offset = "0x63DFC0", VA = "0x18063F9C0")]
		public void Start()
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x63FA60", Offset = "0x63E060", VA = "0x18063FA60", Slot = "13")]
		public override void OnPostScan()
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x63FA70", Offset = "0x63E070", VA = "0x18063FA70", Slot = "19")]
		public virtual void InvertSettings()
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x63FAA0", Offset = "0x63E0A0", VA = "0x18063FAA0")]
		public void RecalcConvex()
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("World space can no longer be used as it does not work well with rotated graphs. Use transform.InverseTransformPoint to transform points to local space.", true)]
		private void ToggleUseWorldSpace()
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("The Y coordinate is no longer important. Use the position of the object instead", true)]
		public void LockToY()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000037C4 File Offset: 0x000019C4
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x63FB60", Offset = "0x63E160", VA = "0x18063FB60")]
		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x6401B0", Offset = "0x63E7B0", VA = "0x1806401B0")]
		public void Apply()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x640F50", Offset = "0x63F550", VA = "0x180640F50")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x640F60", Offset = "0x63F560", VA = "0x180640F60")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x640F70", Offset = "0x63F570", VA = "0x180640F70")]
		private void OnDrawGizmos(bool selected)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x642060", Offset = "0x640660", VA = "0x180642060")]
		public void DisableLegacyMode()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x642210", Offset = "0x640810", VA = "0x180642210", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x642250", Offset = "0x640850", VA = "0x180642250")]
		public GraphUpdateScene()
		{
		}

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x40")]
		public Vector3[] points;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] convexPoints;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x50")]
		public bool convex;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x54")]
		public float minBoundsHeight;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x58")]
		public int penaltyDelta;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x5C")]
		public bool modifyWalkability;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x5D")]
		public bool setWalkability;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x5E")]
		public bool applyOnStart;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x5F")]
		public bool applyOnScan;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x60")]
		public bool updatePhysics;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x61")]
		public bool resetPenaltyOnPhysics;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x62")]
		public bool updateErosion;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x63")]
		public bool modifyTag;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x64")]
		public int setTag;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public bool legacyMode;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x6C")]
		private int setTagInvert;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x70")]
		private bool firstApplied;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private int serializedVersion;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[FormerlySerializedAs("useWorldSpace")]
		private bool legacyUseWorldSpace;
	}
}
