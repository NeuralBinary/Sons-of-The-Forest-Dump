using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class MeshOutliner : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000011 RID: 17 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x17000001")]
	public bool IsEnabled
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x998F20", Offset = "0x997520", VA = "0x180998F20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA5E170", Offset = "0xA5C770", VA = "0x180A5E170")]
	private void Reset()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0xA5E200", Offset = "0xA5C800", VA = "0x180A5E200")]
	private void Initialise()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0xA5E5A0", Offset = "0xA5CBA0", VA = "0x180A5E5A0")]
	public void RefreshMaterials()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0xA5EA90", Offset = "0xA5D090", VA = "0x180A5EA90")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0xA5EAE0", Offset = "0xA5D0E0", VA = "0x180A5EAE0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0xA5EAF0", Offset = "0xA5D0F0", VA = "0x180A5EAF0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0xA5EB00", Offset = "0xA5D100", VA = "0x180A5EB00")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0xA5EC60", Offset = "0xA5D260", VA = "0x180A5EC60")]
	public void SetThickness(float value)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0xA5ED90", Offset = "0xA5D390", VA = "0x180A5ED90")]
	private void Enable(bool enable)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0xA5F020", Offset = "0xA5D620", VA = "0x180A5F020")]
	public MeshOutliner()
	{
	}

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	[ColorUsage(true, true)]
	[SerializeField]
	private Color _color;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _thickness;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Renderer _renderer;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x40")]
	private Material _outlineMaterial;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x48")]
	private List<Material> _originalMaterialList;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x50")]
	private Material[] _outlinedMaterials;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x58")]
	private bool _isInitialised;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	private const string _outlineShaderName = "Sons/Outline/Stencil based Outline Inventory";

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x59")]
	private bool _isEnabled;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _outlineColorProperty;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int _outlineWidthShaderProperty;
}
