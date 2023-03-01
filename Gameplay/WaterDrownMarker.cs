using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x20006D1")]
	[AddComponentMenu("Sons/GamePlay/WaterDrownMarker")]
	public class WaterDrownMarker : MonoBehaviour
	{
		// Token: 0x06002C93 RID: 11411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C93")]
		[Address(RVA = "0x2DFCE60", Offset = "0x2DFBE60", VA = "0x182DFCE60")]
		private void OnEnable()
		{
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C94")]
		[Address(RVA = "0x2DFCDF0", Offset = "0x2DFBDF0", VA = "0x182DFCDF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C95")]
		[Address(RVA = "0x2DFCEC0", Offset = "0x2DFBEC0", VA = "0x182DFCEC0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C96")]
		[Address(RVA = "0x2DFCE50", Offset = "0x2DFBE50", VA = "0x182DFCE50")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C97")]
		[Address(RVA = "0x2DFD350", Offset = "0x2DFC350", VA = "0x182DFD350")]
		private void ValidateMarkerId()
		{
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C98")]
		[Address(RVA = "0x2DFCED0", Offset = "0x2DFBED0", VA = "0x182DFCED0")]
		private void SnapToTerrain()
		{
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C99")]
		[Address(RVA = "0x2DFCD50", Offset = "0x2DFBD50", VA = "0x182DFCD50")]
		public static void LogSelected(GameObject sourceGameObject)
		{
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9A")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public WaterDrownMarker()
		{
		}

		// Token: 0x040027E4 RID: 10212
		[Token(Token = "0x40027E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _snapOffset;

		// Token: 0x040027E5 RID: 10213
		[Token(Token = "0x40027E5")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _tiltUsingSnapOffset;

		// Token: 0x040027E6 RID: 10214
		[Token(Token = "0x40027E6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _markerIdIntegers;

		// Token: 0x040027E7 RID: 10215
		[Token(Token = "0x40027E7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _markerId;

		// Token: 0x040027E8 RID: 10216
		[Token(Token = "0x40027E8")]
		[FieldOffset(Offset = "0x40")]
		private int _instanceId;

		// Token: 0x040027E9 RID: 10217
		[Token(Token = "0x40027E9")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static Dictionary<string, int> _registeredMarkerIds;

		// Token: 0x040027EA RID: 10218
		[Token(Token = "0x40027EA")]
		[FieldOffset(Offset = "0x44")]
		[NonSerialized]
		private bool _validatedMarkerId;
	}
}
