using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029A RID: 666
[Token(Token = "0x200029A")]
public class VisualWorldDebugGrid : MonoBehaviour
{
	// Token: 0x17000211 RID: 529
	// (get) Token: 0x060011C3 RID: 4547 RVA: 0x00006498 File Offset: 0x00004698
	// (set) Token: 0x060011C4 RID: 4548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000211")]
	public bool IsActive
	{
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x6124F0", Offset = "0x610AF0", VA = "0x1806124F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x31CC4F0", Offset = "0x31CAAF0", VA = "0x1831CC4F0")]
	private void Awake()
	{
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x31CC680", Offset = "0x31CAC80", VA = "0x1831CC680")]
	private void Update()
	{
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x31CCB80", Offset = "0x31CB180", VA = "0x1831CCB80")]
	private void OnGUI()
	{
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C8")]
	[Address(RVA = "0x31CD240", Offset = "0x31CB840", VA = "0x1831CD240")]
	private void OnValidate()
	{
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x31CD280", Offset = "0x31CB880", VA = "0x1831CD280")]
	private static string GetCellCoordinatesString(int x, int y)
	{
		return null;
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x31CD310", Offset = "0x31CB910", VA = "0x1831CD310")]
	public string GetCurrentCellCoordinatesString()
	{
		return null;
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x31CD320", Offset = "0x31CB920", VA = "0x1831CD320")]
	private void SetupDebugCommands()
	{
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x000064B0 File Offset: 0x000046B0
	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x31CD420", Offset = "0x31CBA20", VA = "0x1831CD420")]
	private bool ShowDebugZones(string onoff)
	{
		return default(bool);
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x000064C8 File Offset: 0x000046C8
	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x31CD560", Offset = "0x31CBB60", VA = "0x1831CD560")]
	private bool GotoZone(string arguments)
	{
		return default(bool);
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x31CD7D0", Offset = "0x31CBDD0", VA = "0x1831CD7D0")]
	private void ShowZoneDirection(Rect mainIconBg, Vector2 offset, string stringSource)
	{
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x000064E0 File Offset: 0x000046E0
	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x31CD890", Offset = "0x31CBE90", VA = "0x1831CD890")]
	private Vector2 GetCellCentreWorld(int coordX, int coordY)
	{
		return default(Vector2);
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x000064F8 File Offset: 0x000046F8
	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x31CD940", Offset = "0x31CBF40", VA = "0x1831CD940")]
	private Vector2 GetCellSize()
	{
		return default(Vector2);
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x31CD980", Offset = "0x31CBF80", VA = "0x1831CD980")]
	private void CreateVisuals()
	{
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x31CDCE0", Offset = "0x31CC2E0", VA = "0x1831CDCE0")]
	private void CreateSide(Vector3 offset, bool shiftX, Color color)
	{
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x31CE730", Offset = "0x31CCD30", VA = "0x1831CE730")]
	private void DestroyVisuals()
	{
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00006510 File Offset: 0x00004710
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x31CE7D0", Offset = "0x31CCDD0", VA = "0x1831CE7D0")]
	private Color GetRandomColor()
	{
		return default(Color);
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x31CE850", Offset = "0x31CCE50", VA = "0x1831CE850")]
	public VisualWorldDebugGrid()
	{
	}

	// Token: 0x0400117F RID: 4479
	[Token(Token = "0x400117F")]
	private const float _goldenRatio = 0.618034f;

	// Token: 0x04001180 RID: 4480
	[Token(Token = "0x4001180")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2Int _worldSize;

	// Token: 0x04001181 RID: 4481
	[Token(Token = "0x4001181")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2Int _zoneCount;

	// Token: 0x04001182 RID: 4482
	[Token(Token = "0x4001182")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _zoneWallHeight;

	// Token: 0x04001183 RID: 4483
	[Token(Token = "0x4001183")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _zoneWallAlpha;

	// Token: 0x04001184 RID: 4484
	[Token(Token = "0x4001184")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material _visualMaterial;

	// Token: 0x04001185 RID: 4485
	[Token(Token = "0x4001185")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Rect _zoneReadoutPosition;

	// Token: 0x04001186 RID: 4486
	[Token(Token = "0x4001186")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _zoneReadoutOffset;

	// Token: 0x04001187 RID: 4487
	[Token(Token = "0x4001187")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _showGrid;

	// Token: 0x04001188 RID: 4488
	[Token(Token = "0x4001188")]
	[FieldOffset(Offset = "0x55")]
	[SerializeField]
	private bool _showCoordinates;

	// Token: 0x04001189 RID: 4489
	[Token(Token = "0x4001189")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color _gridLineColor;

	// Token: 0x0400118A RID: 4490
	[Token(Token = "0x400118A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _gridLineThickness;

	// Token: 0x0400118B RID: 4491
	[Token(Token = "0x400118B")]
	[FieldOffset(Offset = "0x6C")]
	private Vector2Int _cellCoords;

	// Token: 0x0400118C RID: 4492
	[Token(Token = "0x400118C")]
	[FieldOffset(Offset = "0x78")]
	private GameObject _cellVisuals;

	// Token: 0x0400118D RID: 4493
	[Token(Token = "0x400118D")]
	[FieldOffset(Offset = "0x80")]
	private float _hsvHue;

	// Token: 0x0400118E RID: 4494
	[Token(Token = "0x400118E")]
	[FieldOffset(Offset = "0x84")]
	private readonly float _hsvSaturation;

	// Token: 0x0400118F RID: 4495
	[Token(Token = "0x400118F")]
	[FieldOffset(Offset = "0x88")]
	private readonly float _hsvValue;

	// Token: 0x04001190 RID: 4496
	[Token(Token = "0x4001190")]
	[FieldOffset(Offset = "0x8C")]
	private Vector2Int _previousCoords;

	// Token: 0x04001191 RID: 4497
	[Token(Token = "0x4001191")]
	[FieldOffset(Offset = "0x98")]
	private GUIStyle _style;
}
