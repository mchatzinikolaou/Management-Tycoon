using Management_Tycoon.Core.Enums;

namespace Management_Tycoon.Core.Classes.Employee
{
    public class PersonalityStats
    {

        public class Enneagram
        {
            public EnneagramEnum MainType { get; set; }
            public EnneagramEnum? Wing { get; set; }

            public EnneagramEnum GetPersonalityType()
            {
                return Wing.HasValue ? MainType | Wing.Value : MainType;
            }
        }

        public class SLOAN
        {
            public float Socialization { get; set; }
            public float Limbic { get; set; }
            public float Openness { get; set; }
            public float Agreeableness { get; set; }
            public float Neuroticism { get; set; }

            public SLOAN_TypesEnum GetPersonalityType()
            {
                string sloanStr = "";

                sloanStr += Socialization >= 0.5f ? "S" : "R";
                sloanStr += Limbic >= 0.5f ? "L" : "C";
                sloanStr += Neuroticism >= 0.5f ? "O" : "U";
                sloanStr += Agreeableness >= 0.5f ? "A" : "E";
                sloanStr += Openness >= 0.5f ? "I" : "N";

                return Enum.Parse<SLOAN_TypesEnum>(sloanStr, ignoreCase: true);
            }

            public bool IsSocial()
            {
                return Socialization >= 0.5f;
            }

            public bool IsReserved()
            {
                return Socialization < 0.5f;
            }

            public bool IsLimbic()
            {
                return Limbic >= 0.5f;
            }

            public bool IsCalm()
            {
                return Limbic < 0.5f;
            }

            public bool IsOpen()
            {
                return Openness >= 0.5f;
            }

            public bool IsNotOpen()
            {
                return Openness < 0.5f;
            }

            public bool IsAgreeable()
            {
                return Agreeableness >= 0.5f;
            }

            public bool IsDisagreeable()
            {
                return Agreeableness < 0.5f;
            }

            public bool IsNeurotic()
            {
                return Neuroticism >= 0.5f;
            }

            public bool IsStable()
            {
                return Neuroticism < 0.5f;
            }
        }

        public class MBTI
        {
            public float Extroversion { get; set; }
            public float Intuition { get; set; }
            public float Thinking { get; set; }
            public float Judging { get; set; }

            public MBTI_TypesEnum GetPersonalityType()
            {
                string mbtiStr = "";

                mbtiStr += Extroversion >= 0.5f ? "E" : "I";
                mbtiStr += Intuition >= 0.5f ? "N" : "S";
                mbtiStr += Thinking >= 0.5f ? "T" : "F";
                mbtiStr += Judging >= 0.5f ? "J" : "P";

                return Enum.Parse<MBTI_TypesEnum>(mbtiStr, ignoreCase: true);
            }

            public bool IsExtroverted()
            {
                return Extroversion >= 0.5f;
            }

            public bool IsIntroverted()
            {
                return Extroversion < 0.5f;
            }

            public bool IsIntuitive()
            {
                return Intuition >= 0.5f;
            }

            public bool IsSensing()
            {
                return Intuition < 0.5f;
            }

            public bool IsThinking()
            {
                return Thinking >= 0.5f;
            }

            public bool IsFeeling()
            {
                return Thinking < 0.5f;
            }

            public bool IsJudging()
            {
                return Judging >= 0.5f;
            }

            public bool IsPerceiving()
            {
                return Judging < 0.5f;
            }
        }

    }
}
