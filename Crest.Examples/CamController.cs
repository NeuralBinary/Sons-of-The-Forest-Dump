using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class CamController : MonoBehaviour
{
	// Token: 0x0600000D RID: 13 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x9EEB70", Offset = "0x9ED170", VA = "0x1809EEB70")]
	private void Awake()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x9EF3B0", Offset = "0x9ED9B0", VA = "0x1809EF3B0")]
	private void Update()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x9EF780", Offset = "0x9EDD80", VA = "0x1809EF780")]
	private void UpdateMovement(float dt)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x9F09C0", Offset = "0x9EEFC0", VA = "0x1809F09C0")]
	private void UpdateDragging(float dt)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x9F0D60", Offset = "0x9EF360", VA = "0x1809F0D60")]
	private void UpdateKillRoll()
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x9F0E90", Offset = "0x9EF490", VA = "0x1809F0E90")]
	public CamController()
	{
	}

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x20")]
	public float linSpeed;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x24")]
	public float rotSpeed;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x28")]
	public bool simForwardInput;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x29")]
	public bool _requireLMBToMove;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 _lastMousePos;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x34")]
	private bool _dragging;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x38")]
	public float _fixedDt;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x40")]
	private Transform _targetTransform;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CamController.DebugFields _debug;

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Serializable]
	private class DebugFields
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x6C1AF0", Offset = "0x6C00F0", VA = "0x1806C1AF0")]
		public DebugFields()
		{
		}

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Disables controller preventing the camera from rolling (rotating on the z axis).")]
		public bool disableCameraRollPrevention;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x11")]
		[Tooltip("Disables the XR occlusion mesh for debugging purposes. Only works with legacy XR.")]
		public bool disableOcclusionMesh;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x14")]
		[Range(1f, 2f)]
		[Tooltip("Sets the XR occlusion mesh scale. Useful for debugging refractions. Only works with legacy XR.")]
		public float occlusionMeshScale;
	}
}
