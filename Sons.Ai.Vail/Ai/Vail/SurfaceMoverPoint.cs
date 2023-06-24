using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[AddComponentMenu("Sons/Ai/Surface Mover Point")]
	public class SurfaceMoverPoint : MonoBehaviour
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x1700007C")]
		public bool LinearRotate
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2B54AF0", Offset = "0x2B530F0", VA = "0x182B54AF0")]
		private SurfaceMoverPath GetPath()
		{
			return null;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x2B54B80", Offset = "0x2B53180", VA = "0x182B54B80")]
		public SurfaceMoverPoint NextPoint()
		{
			return null;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2B54C00", Offset = "0x2B53200", VA = "0x182B54C00")]
		public SurfaceMoverPoint RandomNextPoint()
		{
			return null;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public List<SurfaceMoverPoint> NextPoints()
		{
			return null;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2B54C90", Offset = "0x2B53290", VA = "0x182B54C90")]
		public bool IsNextPoint(SurfaceMoverPoint point)
		{
			return default(bool);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x2B54CE0", Offset = "0x2B532E0", VA = "0x182B54CE0")]
		public SurfaceMoverPoint PreviousPoint()
		{
			return null;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2B54D60", Offset = "0x2B53360", VA = "0x182B54D60")]
		public void SetNextPoint(SurfaceMoverPoint nextPoint)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x2B54E00", Offset = "0x2B53400", VA = "0x182B54E00")]
		public void AddNextPoint(SurfaceMoverPoint nextPoint)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2B54F00", Offset = "0x2B53500", VA = "0x182B54F00")]
		public void AddPreviousPoint(SurfaceMoverPoint prevPoint, bool clear = false)
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2B55090", Offset = "0x2B53690", VA = "0x182B55090")]
		public void ClearNextPrevious()
		{
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x2B55120", Offset = "0x2B53720", VA = "0x182B55120")]
		public void RemoveNulls()
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2B553B0", Offset = "0x2B539B0", VA = "0x182B553B0")]
		private void Start()
		{
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void SnapLocalDown()
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2B55440", Offset = "0x2B53A40", VA = "0x182B55440")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SurfaceMoverPoint()
		{
		}

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x20")]
		private SurfaceMoverPath _path;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SurfaceMoverPoint> _nextPoints;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<SurfaceMoverPoint> _previousPoints;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _linearRotate;
	}
}
