using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gui
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public class LookAtCamera : MonoBehaviour
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x3008090", Offset = "0x3006690", VA = "0x183008090")]
		private void Awake()
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3008160", Offset = "0x3006760", VA = "0x183008160")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x3008470", Offset = "0x3006A70", VA = "0x183008470")]
		private void UpdateGoalPosition()
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x30088F0", Offset = "0x3006EF0", VA = "0x1830088F0")]
		private void UpdateGoalRotation()
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x3008EC0", Offset = "0x30074C0", VA = "0x183008EC0")]
		private Camera GetCamera()
		{
			return null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x3008FD0", Offset = "0x30075D0", VA = "0x183008FD0")]
		public LookAtCamera()
		{
		}

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		private const string SceneCameraName = "SceneCamera";

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _speed;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _useThisUp;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _useCameraUp;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x26")]
		[SerializeField]
		private bool _flipForward;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x28")]
		private Camera _targetCamera;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _2dTarget;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _findCamera;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x34")]
		private int _lastSceneViewTime;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x38")]
		private Quaternion _goalRotation;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_sceneOnly")]
		[SerializeField]
		private bool _editorSceneCameraOnly;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _keepDistance;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _distance;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 _baseLocalPosition;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _goalPosition;
	}
}
