using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[AddComponentMenu("Sons/Ai/NavMeshCustomMeshAdd")]
	public class NavMeshCustomMeshAdd : MonoBehaviour
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2A92EC0", Offset = "0x2A914C0", VA = "0x182A92EC0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2A92FB0", Offset = "0x2A915B0", VA = "0x182A92FB0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2A93060", Offset = "0x2A91660", VA = "0x182A93060")]
		private void CollectNavAddLinks()
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2A931B0", Offset = "0x2A917B0", VA = "0x182A931B0")]
		public void DeactivateLinks()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2A931C0", Offset = "0x2A917C0", VA = "0x182A931C0")]
		public void ActivateLinks()
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2A931D0", Offset = "0x2A917D0", VA = "0x182A931D0")]
		public int GetLinkCount()
		{
			return 0;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2A93210", Offset = "0x2A91810", VA = "0x182A93210")]
		private void SetLinksEnabled(bool newEnabled)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2A933F0", Offset = "0x2A919F0", VA = "0x182A933F0")]
		private void CreateCustomMesh(List<Vector3> points, List<int> indices)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2A93710", Offset = "0x2A91D10", VA = "0x182A93710")]
		public void ApplyNavMeshAdd(List<Vector3> points, List<int> indices)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2A93730", Offset = "0x2A91D30", VA = "0x182A93730")]
		public void DisableNavMeshAdd()
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2A93790", Offset = "0x2A91D90", VA = "0x182A93790")]
		private void SetupNavMeshAdd()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2A93AE0", Offset = "0x2A920E0", VA = "0x182A93AE0")]
		public bool TryAddNavLinkToTerrain(Vector3 linkPoint, Vector3 checkPoint)
		{
			return default(bool);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2A940F0", Offset = "0x2A926F0", VA = "0x182A940F0")]
		public void ClearNavAddLinks()
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2A94440", Offset = "0x2A92A40", VA = "0x182A94440")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2A94650", Offset = "0x2A92C50", VA = "0x182A94650")]
		public NavMeshCustomMeshAdd()
		{
		}

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		private const int TerrainMask = 1;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<NavAddLink> _navAddLinks;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x28")]
		private float _navLinkMaxDistance;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _previewMeshFilter;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x38")]
		private Mesh _customNavAddMesh;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x40")]
		private NavmeshAdd _navMeshAdd;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x48")]
		private List<NavMeshCustomMeshAdd.NavLinkLocations> _navLinkTests;

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		private struct NavLinkLocations
		{
			// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xFA1160", Offset = "0xF9F760", VA = "0x180FA1160")]
			public NavLinkLocations(Vector3 inStart, Vector3 inEnd)
			{
			}

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 Start;

			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 End;
		}
	}
}
