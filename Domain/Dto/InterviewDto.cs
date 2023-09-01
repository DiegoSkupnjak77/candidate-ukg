using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Dto
{
    public class InterviewDto
    {
        public int Id { get; set; }
        public string InterviewName { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Feedback { get; set; }
        public bool IsApproved { get; set; }
        public string Reason { get; set; }
        public int IdCandidate { get; set; }
        public int IdJobOpening { get; set; }
        public int IdUser { get; set; }
        public HrDto HrDto { get; set; }
        public CulturalDto CulturalDto { get; set; }
        public TechnicalDto TechnicalDto { get; set; }
        public ManagerDto ManagerDto { get; set; }
        public VpDto VpDto { get; set; }
        public IType TypeInterview { get; set; }
        public enum IType
        {
            Hr = 1,
            Cultural = 2,
            Technical = 3,
            Manager=4,
            Vp=5
        }
    }
    public class InterviewReadDto
    {
        public int Id { get; set; }
        public string InterviewName { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Feedback { get; set; }
        public bool IsApproved { get; set; }
        public string Reason { get; set; }
        public int? IdCandidate { get; set; }
        public int? IdJobOpening { get; set; }
        public int IdUser { get; set; }
        public HrReadDto HrDto { get; set; }
        public CulturalReadDto CulturalDto { get; set; }
        public TechnicalReadDto TechnicalReadDto { get; set; }
        public ManagerReadDto ManagerReadDto { get; set; }
        public VpReadDto VpReadDto { get; set; }
    }
}