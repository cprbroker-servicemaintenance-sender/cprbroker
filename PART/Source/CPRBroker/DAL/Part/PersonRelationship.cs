﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CprBroker.Schemas.Part;

namespace CprBroker.DAL.Part
{
    public partial class PersonRelationship
    {
        public enum RelationshipTypes
        {
            Mother = 1,
            Father = 2,
            Children = 3,
            Spouse = 4,
            RegisteredPartner = 5,
            ResidenceCollection = 6,
            Custody = 7,
            ParentingAdultChildren = 8,
            GuardianOfPerson = 9,
            GuardianshipOwner = 10,
            ReplacementFor = 11,
            ReplacedBy = 12,
        }

        #region Conversion to XML types
        public PersonRelationType ToPersonRelationType()
        {
            return new PersonRelationType
            {
                CommentText = this.CommentText,
                ReferenceID = UnikIdType.Create(RelatedPersonUuid),
                Virkning = Effect.ToVirkningType(Effect)
            };
        }
        public PersonFlerRelationType ToPersonFlerRelationType()
        {
            return new PersonFlerRelationType
            {
                CommentText = this.CommentText,
                ReferenceID = UnikIdType.Create(this.RelatedPersonUuid),
                Virkning = Effect.ToVirkningType(Effect)
            };
        }

        public static Schemas.Part.RelationListeType ToXmlType(IQueryable<PersonRelationship> relations)
        {
            return new CprBroker.Schemas.Part.RelationListeType()
            {
                Aegtefaelle = FilterRelationsByType<PersonRelationType>(relations, RelationshipTypes.Spouse),
                Boern = FilterRelationsByType<PersonFlerRelationType>(relations, RelationshipTypes.Children),
                Bopaelssamling = FilterRelationsByType<PersonFlerRelationType>(relations, RelationshipTypes.ResidenceCollection),
                ErstatningFor = FilterRelationsByType<PersonFlerRelationType>(relations, RelationshipTypes.ReplacementFor),
                ErstatningAf = FilterRelationsByType<PersonRelationType>(relations, RelationshipTypes.ReplacedBy),
                Fader = FilterRelationsByType<PersonRelationType>(relations, RelationshipTypes.Father),
                Moder = FilterRelationsByType<PersonRelationType>(relations, RelationshipTypes.Mother),
                Foraeldremyndighedsboern = FilterRelationsByType<PersonFlerRelationType>(relations, RelationshipTypes.ParentingAdultChildren),
                Foraeldremyndighedsindehaver = FilterRelationsByType<PersonRelationType>(relations, RelationshipTypes.Custody),
                LokalUdvidelse = null,
                RegistreretPartner = FilterRelationsByType<PersonRelationType>(relations, RelationshipTypes.RegisteredPartner),
                RetligHandleevneVaergeForPersonen = FilterRelationsByType<PersonRelationType>(relations, RelationshipTypes.GuardianOfPerson),
                RetligHandleevneVaergemaalsindehaver = FilterRelationsByType<PersonFlerRelationType>(relations, RelationshipTypes.GuardianshipOwner),
            };
        }

        private static TRelation[] FilterRelationsByType<TRelation>(IQueryable<PersonRelationship> relations, RelationshipTypes type) where TRelation : class
        {
            return
            (
                from rel in relations
                where rel.RelationshipTypeId == (int)type
                select typeof(TRelation) == typeof(PersonRelationType) ? rel.ToPersonRelationType() as TRelation : rel.ToPersonFlerRelationType() as TRelation
            ).ToArray();
        }
        #endregion

        #region Creation from XML types
        public static PersonRelationship[] FromXmlType(Schemas.Part.RelationListeType partRelations)
        {
            if (partRelations != null)
            {
                var ret = new List<PersonRelationship>();
                if (partRelations != null)
                {
                    ret.AddRange(ListFromXmlType(partRelations.Aegtefaelle, RelationshipTypes.Spouse));
                    ret.AddRange(ListFromXmlType(partRelations.Boern, RelationshipTypes.Children));
                    ret.AddRange(ListFromXmlType(partRelations.Bopaelssamling, RelationshipTypes.ResidenceCollection));
                    ret.AddRange(ListFromXmlType(partRelations.ErstatningFor, RelationshipTypes.ReplacementFor));
                    ret.AddRange(ListFromXmlType(partRelations.ErstatningAf, RelationshipTypes.ReplacedBy));
                    ret.AddRange(ListFromXmlType(partRelations.Fader, RelationshipTypes.Father));
                    ret.AddRange(ListFromXmlType(partRelations.Moder, RelationshipTypes.Mother));
                    ret.AddRange(ListFromXmlType(partRelations.Foraeldremyndighedsboern, RelationshipTypes.ParentingAdultChildren));
                    ret.AddRange(ListFromXmlType(partRelations.Foraeldremyndighedsindehaver, RelationshipTypes.Custody));
                    ret.AddRange(ListFromXmlType(partRelations.RegistreretPartner, RelationshipTypes.RegisteredPartner));
                    ret.AddRange(ListFromXmlType(partRelations.RetligHandleevneVaergeForPersonen, RelationshipTypes.GuardianOfPerson));
                    ret.AddRange(ListFromXmlType(partRelations.RetligHandleevneVaergemaalsindehaver, RelationshipTypes.GuardianshipOwner));
                }
                return ret.ToArray();
            }
            return new PersonRelationship[0];
        }

        private static PersonRelationship[] ListFromXmlType(PersonRelationType[] oio, RelationshipTypes relType)
        {
            if (oio != null)
            {
                return oio.AsQueryable()
                    .Where(o => o != null)
                    .Select(
                        r => new PersonRelationship()
                        {
                            CommentText = r.CommentText,
                            Effect = Effect.FromVirkningType(r.Virkning),
                            PersonRelationshipId = Guid.NewGuid(),
                            RelatedPersonUuid = new Guid(r.ReferenceID.Item),
                            RelationshipTypeId = (int)relType
                        }
                    )
                    .ToArray();
            }
            return new PersonRelationship[0];
        }

        private static PersonRelationship[] ListFromXmlType(PersonFlerRelationType[] oio, RelationshipTypes relType)
        {
            if (oio != null)
            {
                return oio.AsQueryable()
                    .Where(r => r != null)
                    .Select(
                        r => new PersonRelationship()
                        {
                            CommentText = r.CommentText,
                            Effect = Effect.FromVirkningType(r.Virkning),
                            PersonRelationshipId = Guid.NewGuid(),
                            RelatedPersonUuid = new Guid(r.ReferenceID.Item),
                            RelationshipTypeId = (int)relType
                        }
                    )
                    .ToArray();
            }
            return new PersonRelationship[0];
        }
        #endregion
    }
}
