using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A6 RID: 678
[Token(Token = "0x20002A6")]
public class VisualWorldDebugGrid : MonoBehaviour
{
	// Token: 0x17000208 RID: 520
	// (get) Token: 0x0600118E RID: 4494 RVA: 0x00006210 File Offset: 0x00004410
	// (set) Token: 0x0600118F RID: 4495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000208")]
	public bool IsActive
	{
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x58ECB0", Offset = "0x58DCB0", VA = "0x18058ECB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600118F")]
		[Address(RVA = "0x589EC0", Offset = "0x588EC0", VA = "0x180589EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001190")]
	[Address(RVA = "0x2B8E410", Offset = "0x2B8D410", VA = "0x182B8E410")]
	private void Awake()
	{
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001191")]
	[Address(RVA = "0x2B8FCE0", Offset = "0x2B8ECE0", VA = "0x182B8FCE0")]
	private void Update()
	{
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001192")]
	[Address(RVA = "0x2B8F180", Offset = "0x2B8E180", VA = "0x182B8F180")]
	private void OnGUI()
	{
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001193")]
	[Address(RVA = "0x2B8F9F0", Offset = "0x2B8E9F0", VA = "0x182B8F9F0")]
	private void OnValidate()
	{
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001194")]
	[Address(RVA = "0x2B8EDA0", Offset = "0x2B8DDA0", VA = "0x182B8EDA0")]
	private static string GetCellCoordinatesString(int x, int y)
	{
		return null;
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001195")]
	[Address(RVA = "0x2B8EE70", Offset = "0x2B8DE70", VA = "0x182B8EE70")]
	public string GetCurrentCellCoordinatesString()
	{
		return null;
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001196")]
	[Address(RVA = "0x2B8FA30", Offset = "0x2B8EA30", VA = "0x182B8FA30")]
	private void SetupDebugCommands()
	{
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00006228 File Offset: 0x00004428
	[Token(Token = "0x6001197")]
	[Address(RVA = "0x2B8FB30", Offset = "0x2B8EB30", VA = "0x182B8FB30")]
	private bool ShowDebugZones(string onoff)
	{
		return default(bool);
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00006240 File Offset: 0x00004440
	[Token(Token = "0x6001198")]
	[Address(RVA = "0x2B8EF00", Offset = "0x2B8DF00", VA = "0x182B8EF00")]
	private bool GotoZone(string arguments)
	{
		return default(bool);
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001199")]
	[Address(RVA = "0x2B8FC20", Offset = "0x2B8EC20", VA = "0x182B8FC20")]
	private void ShowZoneDirection(Rect mainIconBg, Vector2 offset, string stringSource)
	{
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00006258 File Offset: 0x00004458
	[Token(Token = "0x600119A")]
	[Address(RVA = "0x2B8ECF0", Offset = "0x2B8DCF0", VA = "0x182B8ECF0")]
	private Vector2 GetCellCentreWorld(int coordX, int coordY)
	{
		return default(Vector2);
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00006270 File Offset: 0x00004470
	[Token(Token = "0x600119B")]
	[Address(RVA = "0x2B8EE30", Offset = "0x2B8DE30", VA = "0x182B8EE30")]
	private Vector2 GetCellSize()
	{
		return default(Vector2);
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119C")]
	[Address(RVA = "0x2B8E9E0", Offset = "0x2B8D9E0", VA = "0x182B8E9E0")]
	private void CreateVisuals()
	{
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119D")]
	[Address(RVA = "0x2B8E530", Offset = "0x2B8D530", VA = "0x182B8E530")]
	private void CreateSide(Vector3 offset, bool shiftX, Color color)
	{
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119E")]
	[Address(RVA = "0x2B8EC80", Offset = "0x2B8DC80", VA = "0x182B8EC80")]
	private void DestroyVisuals()
	{
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00006288 File Offset: 0x00004488
	[Token(Token = "0x600119F")]
	[Address(RVA = "0x2B8EE80", Offset = "0x2B8DE80", VA = "0x182B8EE80")]
	private Color GetRandomColor()
	{
		return default(Color);
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x2B90050", Offset = "0x2B8F050", VA = "0x182B90050")]
	public VisualWorldDebugGrid()
	{
	}

	// Token: 0x04001158 RID: 4440
	[Token(Token = "0x4001158")]
	private const float _goldenRatio = 0.618034f;

	// Token: 0x04001159 RID: 4441
	[Token(Token = "0x4001159")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2Int _worldSize;

	// Token: 0x0400115A RID: 4442
	[Token(Token = "0x400115A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2Int _zoneCount;

	// Token: 0x0400115B RID: 4443
	[Token(Token = "0x400115B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _zoneWallHeight;

	// Token: 0x0400115C RID: 4444
	[Token(Token = "0x400115C")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _zoneWallAlpha;

	// Token: 0x0400115D RID: 4445
	[Token(Token = "0x400115D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material _visualMaterial;

	// Token: 0x0400115E RID: 4446
	[Token(Token = "0x400115E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Rect _zoneReadoutPosition;

	// Token: 0x0400115F RID: 4447
	[Token(Token = "0x400115F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _zoneReadoutOffset;

	// Token: 0x04001160 RID: 4448
	[Token(Token = "0x4001160")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _showGrid;

	// Token: 0x04001161 RID: 4449
	[Token(Token = "0x4001161")]
	[FieldOffset(Offset = "0x55")]
	[SerializeField]
	private bool _showCoordinates;

	// Token: 0x04001162 RID: 4450
	[Token(Token = "0x4001162")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color _gridLineColor;

	// Token: 0x04001163 RID: 4451
	[Token(Token = "0x4001163")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _gridLineThickness;

	// Token: 0x04001164 RID: 4452
	[Token(Token = "0x4001164")]
	[FieldOffset(Offset = "0x6C")]
	private Vector2Int _cellCoords;

	// Token: 0x04001165 RID: 4453
	[Token(Token = "0x4001165")]
	[FieldOffset(Offset = "0x78")]
	private GameObject _cellVisuals;

	// Token: 0x04001166 RID: 4454
	[Token(Token = "0x4001166")]
	[FieldOffset(Offset = "0x80")]
	private float _hsvHue;

	// Token: 0x04001167 RID: 4455
	[Token(Token = "0x4001167")]
	[FieldOffset(Offset = "0x84")]
	private readonly float _hsvSaturation;

	// Token: 0x04001168 RID: 4456
	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x88")]
	private readonly float _hsvValue;

	// Token: 0x04001169 RID: 4457
	[Token(Token = "0x4001169")]
	[FieldOffset(Offset = "0x8C")]
	private Vector2Int _previousCoords;

	// Token: 0x0400116A RID: 4458
	[Token(Token = "0x400116A")]
	[FieldOffset(Offset = "0x98")]
	private GUIStyle _style;
}
