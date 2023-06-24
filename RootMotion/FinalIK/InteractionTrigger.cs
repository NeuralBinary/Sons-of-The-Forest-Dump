using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		// Token: 0x0600052B RID: 1323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2980150", Offset = "0x297E750", VA = "0x182980150")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x29801E0", Offset = "0x297E7E0", VA = "0x1829801E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2980270", Offset = "0x297E870", VA = "0x182980270")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2980300", Offset = "0x297E900", VA = "0x182980300")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2980390", Offset = "0x297E990", VA = "0x182980390")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Start()
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2980420", Offset = "0x297EA20", VA = "0x182980420")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return 0;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2980730", Offset = "0x297ED30", VA = "0x182980730")]
		public InteractionTrigger()
		{
		}

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public InteractionTrigger.Range[] ranges;

		// Token: 0x02000091 RID: 145
		[Token(Token = "0x2000091")]
		[Serializable]
		public class CharacterPosition
		{
			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000533 RID: 1331 RVA: 0x00004094 File Offset: 0x00002294
			[Token(Token = "0x1700008D")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000533")]
				[Address(RVA = "0x29807F0", Offset = "0x297EDF0", VA = "0x1829807F0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000534 RID: 1332 RVA: 0x000040AC File Offset: 0x000022AC
			[Token(Token = "0x1700008E")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000534")]
				[Address(RVA = "0x2980810", Offset = "0x297EE10", VA = "0x182980810")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x000040C4 File Offset: 0x000022C4
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x2980930", Offset = "0x297EF30", VA = "0x182980930")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x2981500", Offset = "0x297FB00", VA = "0x182981500")]
			public CharacterPosition()
			{
			}

			// Token: 0x040004A0 RID: 1184
			[Token(Token = "0x40004A0")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			// Token: 0x040004A1 RID: 1185
			[Token(Token = "0x40004A1")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			// Token: 0x040004A2 RID: 1186
			[Token(Token = "0x40004A2")]
			[FieldOffset(Offset = "0x1C")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			// Token: 0x040004A3 RID: 1187
			[Token(Token = "0x40004A3")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			// Token: 0x040004A4 RID: 1188
			[Token(Token = "0x40004A4")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			// Token: 0x040004A5 RID: 1189
			[Token(Token = "0x40004A5")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			// Token: 0x040004A6 RID: 1190
			[Token(Token = "0x40004A6")]
			[FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;
		}

		// Token: 0x02000092 RID: 146
		[Token(Token = "0x2000092")]
		[Serializable]
		public class CameraPosition
		{
			// Token: 0x06000537 RID: 1335 RVA: 0x000040DC File Offset: 0x000022DC
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x2981510", Offset = "0x297FB10", VA = "0x182981510")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x000040F4 File Offset: 0x000022F4
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x29817E0", Offset = "0x297FDE0", VA = "0x1829817E0")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x2981C30", Offset = "0x2980230", VA = "0x182981C30")]
			public CameraPosition()
			{
			}

			// Token: 0x040004A7 RID: 1191
			[Token(Token = "0x40004A7")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			// Token: 0x040004A8 RID: 1192
			[Token(Token = "0x40004A8")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			// Token: 0x040004A9 RID: 1193
			[Token(Token = "0x40004A9")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			// Token: 0x040004AA RID: 1194
			[Token(Token = "0x40004AA")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			// Token: 0x040004AB RID: 1195
			[Token(Token = "0x40004AB")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;
		}

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		[Serializable]
		public class Range
		{
			// Token: 0x0600053A RID: 1338 RVA: 0x0000410C File Offset: 0x0000230C
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x2981CC0", Offset = "0x29802C0", VA = "0x182981CC0")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1487590", Offset = "0x1485B90", VA = "0x181487590")]
			public Range()
			{
			}

			// Token: 0x040004AC RID: 1196
			[Token(Token = "0x40004AC")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			// Token: 0x040004AD RID: 1197
			[Token(Token = "0x40004AD")]
			[FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			// Token: 0x040004AE RID: 1198
			[Token(Token = "0x40004AE")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public InteractionTrigger.CharacterPosition characterPosition;

			// Token: 0x040004AF RID: 1199
			[Token(Token = "0x40004AF")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public InteractionTrigger.CameraPosition cameraPosition;

			// Token: 0x040004B0 RID: 1200
			[Token(Token = "0x40004B0")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public InteractionTrigger.Range.Interaction[] interactions;

			// Token: 0x02000094 RID: 148
			[Token(Token = "0x2000094")]
			[Serializable]
			public class Interaction
			{
				// Token: 0x0600053C RID: 1340 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600053C")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public Interaction()
				{
				}

				// Token: 0x040004B1 RID: 1201
				[Token(Token = "0x40004B1")]
				[FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				// Token: 0x040004B2 RID: 1202
				[Token(Token = "0x40004B2")]
				[FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;
			}
		}
	}
}
