using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[AddComponentMenu("Pathfinding/Seeker")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_seeker.php")]
	public class Seeker : VersionedMonoBehaviour
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x6302A0", Offset = "0x62E8A0", VA = "0x1806302A0")]
		public Seeker()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x6305B0", Offset = "0x62EBB0", VA = "0x1806305B0", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
		public Path GetCurrentPath()
		{
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x6306E0", Offset = "0x62ECE0", VA = "0x1806306E0")]
		public void CancelCurrentPathRequest(bool pool = true)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x630770", Offset = "0x62ED70", VA = "0x180630770")]
		public void OnDestroy()
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x6308D0", Offset = "0x62EED0", VA = "0x1806308D0")]
		private void ReleaseClaimedPath()
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x630950", Offset = "0x62EF50", VA = "0x180630950")]
		public void RegisterModifier(IPathModifier modifier)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x630B20", Offset = "0x62F120", VA = "0x180630B20")]
		public void DeregisterModifier(IPathModifier modifier)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x630B80", Offset = "0x62F180", VA = "0x180630B80")]
		public void PostProcess(Path path)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x630B90", Offset = "0x62F190", VA = "0x180630B90")]
		public void RunModifiers(Seeker.ModifierPass pass, Path path)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x630E30", Offset = "0x62F430", VA = "0x180630E30")]
		public bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x630E50", Offset = "0x62F450", VA = "0x180630E50")]
		private void OnPathComplete(Path path)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x630E70", Offset = "0x62F470", VA = "0x180630E70")]
		private void OnPathComplete(Path p, bool runModifiers, bool sendCallbacks)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x631050", Offset = "0x62F650", VA = "0x180631050")]
		private void OnPartialPathComplete(Path p)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x631140", Offset = "0x62F740", VA = "0x180631140")]
		private void OnMultiPathComplete(Path p)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x631160", Offset = "0x62F760", VA = "0x180631160")]
		[Obsolete("Use ABPath.Construct(start, end, null) instead")]
		public ABPath GetNewPath(Vector3 start, Vector3 end)
		{
			return null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x6311F0", Offset = "0x62F7F0", VA = "0x1806311F0")]
		public Path StartPath(Vector3 start, Vector3 end)
		{
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x6312C0", Offset = "0x62F8C0", VA = "0x1806312C0")]
		public Path StartPath(Vector3 start, Vector3 end, OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x6313A0", Offset = "0x62F9A0", VA = "0x1806313A0")]
		public Path StartPath(Vector3 start, Vector3 end, OnPathDelegate callback, GraphMask graphMask)
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x631470", Offset = "0x62FA70", VA = "0x180631470")]
		public Path StartPath(Path p, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x6314B0", Offset = "0x62FAB0", VA = "0x1806314B0")]
		public Path StartPath(Path p, OnPathDelegate callback, GraphMask graphMask)
		{
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x6314F0", Offset = "0x62FAF0", VA = "0x1806314F0")]
		private void StartPathInternal(Path p, OnPathDelegate callback)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x6319E0", Offset = "0x62FFE0", VA = "0x1806319E0")]
		public MultiTargetPath StartMultiTargetPath(Vector3 start, Vector3[] endPoints, bool pathsForAll, [Optional] OnPathDelegate callback, int graphMask = -1)
		{
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x631A80", Offset = "0x630080", VA = "0x180631A80")]
		public MultiTargetPath StartMultiTargetPath(Vector3[] startPoints, Vector3 end, bool pathsForAll, [Optional] OnPathDelegate callback, int graphMask = -1)
		{
			return null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x6314B0", Offset = "0x62FAB0", VA = "0x1806314B0")]
		[Obsolete("You can use StartPath instead of this method now. It will behave identically.")]
		public MultiTargetPath StartMultiTargetPath(MultiTargetPath p, [Optional] OnPathDelegate callback, int graphMask = -1)
		{
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x631B20", Offset = "0x630120", VA = "0x180631B20")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x631F30", Offset = "0x630530", VA = "0x180631F30", Slot = "9")]
		protected override int OnUpgradeSerializedData(int version, bool unityThread)
		{
			return 0;
		}

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool drawGizmos;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool detailedGizmos;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public StartEndModifier startEndModifier;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public int traversableTags;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public int[] tagPenalties;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public GraphMask graphMask;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("graphMask")]
		private int graphMaskCompatibility;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OnPathDelegate pathCallback;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OnPathDelegate preProcessPath;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public OnPathDelegate postProcessPath;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private List<Vector3> lastCompletedVectorPath;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private List<GraphNode> lastCompletedNodePath;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		protected Path path;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private Path prevPath;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly OnPathDelegate onPathDelegate;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly OnPathDelegate onPartialPathDelegate;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private OnPathDelegate tmpPathCallback;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected uint lastPathID;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly List<IPathModifier> modifiers;

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		public enum ModifierPass
		{
			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			PreProcess,
			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			PostProcess = 2
		}
	}
}
