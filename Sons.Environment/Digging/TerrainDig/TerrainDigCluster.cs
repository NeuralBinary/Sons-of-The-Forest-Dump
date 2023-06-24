using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[Serializable]
	public class TerrainDigCluster
	{
		// Token: 0x06000197 RID: 407 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
		public bool IsDisposed()
		{
			return default(bool);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2FB56E0", Offset = "0x2FB3CE0", VA = "0x182FB56E0")]
		public bool Add(TerrainDigNode node, bool refreshBounds = false)
		{
			return default(bool);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2FB5BD0", Offset = "0x2FB41D0", VA = "0x182FB5BD0")]
		private float CalculateAdjacentDepth(int roundedPointX, int roundedPointY)
		{
			return 0f;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2FB61A0", Offset = "0x2FB47A0", VA = "0x182FB61A0")]
		private List<TerrainDigNode> GetAdjacentNodes(int roundedPointX, int roundedPointY, int border, bool includeNull = false)
		{
			return null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2FB6590", Offset = "0x2FB4B90", VA = "0x182FB6590")]
		private void GetAdjacentNodes(int roundedPointX, int roundedPointY, out TerrainDigNode north, out TerrainDigNode east, out TerrainDigNode south, out TerrainDigNode west, out TerrainDigNode northEast, out TerrainDigNode southEast, out TerrainDigNode southWest, out TerrainDigNode northWest)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2FB6C10", Offset = "0x2FB5210", VA = "0x182FB6C10")]
		private bool IsValidCoord(int pointX, int pointY)
		{
			return default(bool);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2FB6CD0", Offset = "0x2FB52D0", VA = "0x182FB6CD0")]
		private void DebugCheckGridPositions()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2FB7130", Offset = "0x2FB5730", VA = "0x182FB7130")]
		private TerrainDigNode GetNode(int roundedPointX, int roundedPointY)
		{
			return null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2FB7230", Offset = "0x2FB5830", VA = "0x182FB7230")]
		private void PadGrid(int xIndex, int yIndex)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2FB7440", Offset = "0x2FB5A40", VA = "0x182FB7440")]
		public void Remove(TerrainDigNode node)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2FB75F0", Offset = "0x2FB5BF0", VA = "0x182FB75F0")]
		private void RemoveAt(int index, TerrainDigNode node)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2FB7720", Offset = "0x2FB5D20", VA = "0x182FB7720")]
		public static void MergeNodes(ref List<DiggingVirtualNode> finalNodes, float threshold, float secondaryThreshold)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2FB78A0", Offset = "0x2FB5EA0", VA = "0x182FB78A0")]
		public static void MergeNode(ref List<DiggingVirtualNode> finalNodes, int aIndex, int sourceNodeCount, float threshold, float secondaryThreshold)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2FB79D0", Offset = "0x2FB5FD0", VA = "0x182FB79D0")]
		public static bool DoMerge(ref List<DiggingVirtualNode> finalNodes, int aIndex, int bIndex, int sourceNodeCount, float threshold, float secondaryThreshold)
		{
			return default(bool);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2FB8130", Offset = "0x2FB6730", VA = "0x182FB8130")]
		public void Refresh()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2FB8EE0", Offset = "0x2FB74E0", VA = "0x182FB8EE0")]
		private void SetActive(int roundedPointX, int roundedPointY, int xOffset, int yOffset, float relativePosY, float depth)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2FB9080", Offset = "0x2FB7680", VA = "0x182FB9080")]
		private List<DiggingVirtualNode> CalculateInbetweens(List<DiggingVirtualNode> virtualNodes, float nodeSize)
		{
			return null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2FB9210", Offset = "0x2FB7810", VA = "0x182FB9210")]
		private void ProcessMergeResult(List<DiggingVirtualNode> diggingVirtualNodes, List<TerrainDigNode> terrainDigNodes)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2FB9890", Offset = "0x2FB7E90", VA = "0x182FB9890")]
		private void Merge(TerrainDigNode sourceNode, TerrainDigNode otherNode)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2FB9930", Offset = "0x2FB7F30", VA = "0x182FB9930")]
		private bool ShouldMerge(TerrainDigNode sourceNode, TerrainDigNode otherNode)
		{
			return default(bool);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2FB99C0", Offset = "0x2FB7FC0", VA = "0x182FB99C0")]
		private void GetGridPositions(Vector3 position, out Vector3 relativePos, out float nodeXScaled, out float nodeYScaled, out int roundedPointX, out int roundedPointY)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2FB9AE0", Offset = "0x2FB80E0", VA = "0x182FB9AE0")]
		private void GetSnappedPositions(float relativePosX, float relativePosZ, out float nodeXScaled, out float nodeYScaled, out int roundedPointX, out int roundedPointY)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2FB9B30", Offset = "0x2FB8130", VA = "0x182FB9B30")]
		private Vector3d GetNormals(int arg)
		{
			return default(Vector3d);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2FB9C20", Offset = "0x2FB8220", VA = "0x182FB9C20")]
		private Vector3d GetPositions(int arg)
		{
			return default(Vector3d);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2FB9D10", Offset = "0x2FB8310", VA = "0x182FB9D10")]
		private void RefreshBounds()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2FBA110", Offset = "0x2FB8710", VA = "0x182FBA110")]
		private void ShiftGridNodes(Vector3 shift)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2FBA4B0", Offset = "0x2FB8AB0", VA = "0x182FBA4B0")]
		private void ReinitializeNodeGrid()
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2FBA4F0", Offset = "0x2FB8AF0", VA = "0x182FBA4F0")]
		public bool IsTouching(TerrainDigNode node)
		{
			return default(bool);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2FBA740", Offset = "0x2FB8D40", VA = "0x182FBA740")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2FBA880", Offset = "0x2FB8E80", VA = "0x182FBA880")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2FBACE0", Offset = "0x2FB92E0", VA = "0x182FBACE0")]
		public void Dispose()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2FBAF60", Offset = "0x2FB9560", VA = "0x182FBAF60")]
		public void TransferTo(TerrainDigCluster targetCluster)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2FBB2A0", Offset = "0x2FB98A0", VA = "0x182FBB2A0")]
		public void SetMergeThresholds(float threshold, float secondaryThreshold)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2FBB2B0", Offset = "0x2FB98B0", VA = "0x182FBB2B0")]
		public void SetSize(float nodeSize)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2FBB2C0", Offset = "0x2FB98C0", VA = "0x182FBB2C0")]
		public Mesh GetMesh()
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2FBB2E0", Offset = "0x2FB98E0", VA = "0x182FBB2E0")]
		public Vector3 GetCenter()
		{
			return default(Vector3);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2FBB300", Offset = "0x2FB9900", VA = "0x182FBB300")]
		public Vector3 GetMin()
		{
			return default(Vector3);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x718F50", Offset = "0x717550", VA = "0x180718F50")]
		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetNodeDepths(float[] nodeDepths)
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2FBB360", Offset = "0x2FB9960", VA = "0x182FBB360")]
		public bool HasNode(Vector3 point, out TerrainDigNode terrainDigNode)
		{
			return default(bool);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2FBB650", Offset = "0x2FB9C50", VA = "0x182FBB650")]
		public bool Contains(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2FBB6C0", Offset = "0x2FB9CC0", VA = "0x182FBB6C0")]
		public bool IsBlocked(Vector3 vector3)
		{
			return default(bool);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2FBB760", Offset = "0x2FB9D60", VA = "0x182FBB760")]
		private bool IsMaxDepth(TerrainDigNode terrainDigNode)
		{
			return default(bool);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
		public void SetObjectReferences(ClusterObjectRefs newRefs)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2FBB7D0", Offset = "0x2FB9DD0", VA = "0x182FBB7D0")]
		public TerrainDigCluster()
		{
		}

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Bounds _bounds;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_nodeDepth")]
		private float[] _nodeDepths;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<TerrainDigNode> _nodes;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x38")]
		private List<List<TerrainDigNode>> _nodeGrid;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x40")]
		private bool _structureElementEnabled;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Mesh _myMesh;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TerrainDigCollisionGrid _collisionGrid;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x58")]
		private float _nodeSize;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x60")]
		private List<DiggingVirtualNode> _virtualNodes;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x68")]
		private float _mergeThreshold;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x6C")]
		private float _mergeSecondaryThreshold;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x70")]
		private bool _boundsSet;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		private bool _drawMerged;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x78")]
		private ClusterObjectRefs _objectReferences;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x80")]
		private bool _isDisposed;
	}
}
